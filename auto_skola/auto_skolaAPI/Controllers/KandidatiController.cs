using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using auto_skolaAPI.KNN;
using auto_skolaAPI.Models;

namespace auto_skolaAPI.Controllers
{
    public class KandidatiController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        [HttpGet]
        [Route("api/Kandidati")]
        public List<asp_Kandidati_SelectAll_Result> GetKandidati()
        {
            return db.asp_Kandidati_SelectAll().ToList();
        }


        // GET: api/Kandidati/5
        [ResponseType(typeof(Kandidati))]
        [Route("api/Kandidati/{id}", Name = "GetKandidati")]
        [HttpGet]
        public IHttpActionResult GetKandidati(int id)
        {
            asp_Kandidati_GetById_Result kandidati = db.asp_Kandidati_GetById(id).FirstOrDefault();
            if (kandidati == null)
            {
                return NotFound();
            }

            return Ok(kandidati);
        }

        [Route("api/Kandidati/GetBrojNovihKandidata/{KandidatId}")]
        [ResponseType(typeof(int))]
        [HttpGet]
        public IHttpActionResult GetBrojNovihKandidata(int KandidatId)
        {
            int brojKandidata = db.asp_Kandidati_GetBrojNovihKandidata(KandidatId).FirstOrDefault() ?? 0;

            return Ok(brojKandidata);
        }

        [Route("api/Kandidati/GetBrojKandidata")]
        [ResponseType(typeof(int))]
        [HttpGet]
        public IHttpActionResult GetBrojKandidata()
        {
            int brojKandidata = db.Kandidati.Count();

            return Ok(brojKandidata);
        }

        [Route("api/Kandidati/GetByUsername/{username}")]
        [HttpGet]
        public IHttpActionResult GetByUsername(string username)
        {
            //Kandidati k = db.Kandidati.Where(x => x.KorisnickoIme == username).FirstOrDefault();
            asp_Kandidati_GetByUsername_Result k = db.asp_Kandidati_GetByUsername(username).FirstOrDefault();

            if (k == null)
                return NotFound();

            return Ok(k);
        }
        //api/Kandidati/
        [Route("api/Kandidati/GetKandidatImePrezime")]
        public List<asp_Kandidati_SpojenoImePrezime_Result> GetKandidatImePrezime()
        {
            return db.asp_Kandidati_SpojenoImePrezime().ToList();
        }

        [HttpPost]
        [Route("api/Kandidati/CustomPostKandidati/{p}")]
        public IHttpActionResult CustomPostKandidati(int p, Kandidati obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (obj == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Kandidati.Add(obj);
            db.SaveChanges();

            return CreatedAtRoute("GetKandidati", new { id = obj.KandidatId }, obj);
        }
        //METHOD NOT ALLOWED
        //[HttpPost]
        //[ResponseType(typeof(Kandidati))]
        //[Route("api/Kandidati/PostKandidati/{obj}")]
        //public IHttpActionResult PostKandidati(Kandidati obj)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    if (obj == null)
        //        return NotFound();

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Kandidati.Add(obj);
        //    db.SaveChanges();

        //    return CreatedAtRoute("GetKandidati", new { id = obj.KandidatId }, obj);
        //}

        // PUT: api/Kandidati/5
        [ResponseType(typeof(void))]
        [Route("api/Kandidati/{id}", Name = "PutKandidati")]
        public IHttpActionResult PutKandidati(int id, Kandidati kandidati)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kandidati.KandidatId)
            {
                return BadRequest();
            }

            db.Entry(kandidati).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KandidatiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }





        [HttpGet]
        [Route("api/Kandidati/SearchByName/{name?}")]
        public List<asp_Kandidati_SearchByName_Result> SearchByName(string name = "")
        {
            return db.asp_Kandidati_SearchByName(name).ToList();
        }

        [HttpGet]
        [Route("api/Kandidati/GetPodaciZaKNN")]
        public List<asp_Podaci_Za_KNN_Result> GetPodaciZaKNN()
        {
            return db.asp_Podaci_Za_KNN().ToList();
        }

        [HttpGet]
        [Route("api/Kandidati/GetNepolozeniKandidati")]
        public List<asp_Podaci_Za_KNN_Result> GetNepolozeniKandidati()
        {
            return db.asp_NepolozeniKandidati(0).ToList();
        }

        [HttpGet]
        [Route("api/Kandidati/ReportKNN/{KandidatId}")]
        public List<asp_ReportKNN_Result> ReportKNN(int KandidatId)
        {
            List<asp_Podaci_Za_KNN_Result> ulazniPodaci = db.asp_Podaci_Za_KNN().ToList();
            List<asp_Podaci_Za_KNN_Result> podaciZaTestiranje = db.asp_NepolozeniKandidati(KandidatId).ToList();

            List<Kandidati> trainKandidati = PretvoriUKandidata(ulazniPodaci);
            List<Kandidati> nepolozeniKandidati = PretvoriUKandidata(podaciZaTestiranje);

            int k = Math.Min(3, trainKandidati.Count);

            Algorithm alg = new Algorithm(k, trainKandidati, nepolozeniKandidati);
            alg.runkNN();

            List<asp_ReportKNN_Result> rezultatKNN = new List<asp_ReportKNN_Result>();
            List<Kandidati> rezultat = alg.getKandidatList();

            foreach(Kandidati kandidat in rezultat)
            {
                rezultatKNN.Add(new asp_ReportKNN_Result
                {
                    ImePrezime = kandidat.Ime + " " + kandidat.Prezime,
                    DatumRodjenja = kandidat.DatumRodjenja,
                    KandidatId = kandidat.KandidatId,
                    PredvidjeniBrojIzlazaka = kandidat.PredvidjeniBrojIzlazakaNaVoznju,
                    Spol = kandidat.Spol.Naziv,
                    StrucnaSprema = kandidat.StrucnaSprema.Naziv
                });
            }

            return rezultatKNN;

        }

        private List<Kandidati> PretvoriUKandidata(List<asp_Podaci_Za_KNN_Result> ulazniPodaci)
        {
            return ulazniPodaci.Select(x => new Kandidati
            {
                BrojIzlazakaNaVoznju = x.BrojIzlazaka.Value,
                DatumRodjenja = x.DatumRodjenja,
                Ime = x.Ime,
                Prezime = x.Prezime,
                StrucnaSprema = new StrucnaSprema
                {
                    Naziv = x.StrucnaSprema,
                    StepenObrazovanja = x.StepenObrazovanja
                },
                Spol = new Spol
                {
                    Naziv = x.Spol
                },
                SpolId = x.SpolId,
                KandidatId = x.KandidatId,
            }).ToList();
        }

        // DELETE: api/Kandidati/5
        [ResponseType(typeof(Kandidati))]
        public IHttpActionResult DeleteKandidati(int id)
        {
            Kandidati kandidati = db.Kandidati.Find(id);
            if (kandidati == null)
            {
                return NotFound();
            }

            db.Kandidati.Remove(kandidati);
            db.SaveChanges();

            return Ok(kandidati);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KandidatiExists(int id)
        {
            return db.Kandidati.Count(e => e.KandidatId == id) > 0;
        }
    }
}
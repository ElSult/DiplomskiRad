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
using auto_skolaAPI.Models;

namespace auto_skolaAPI.Controllers
{
    public class TerminController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        public List<asp_Termin_SelectAll_Result> GetTermin()
        {
            return db.asp_Termin_SelectAll().ToList();
        }

        [HttpGet]
        [Route("api/Termin/SearchByName/{name?}")]
        public List<asp_Termin_SearchByName_Result> SearchByName(string name = "")
        {
            return db.asp_Termin_SearchByName(name).ToList();
        }

        [HttpGet]
        [Route("api/Termin/GetByKandidatId/{KandidatId}")]
        public List<asp_Termin_GetByKandidatId_Result> GetByKandidatId(int KandidatId)
        {
            return db.asp_Termin_GetByKandidatId(KandidatId).ToList();
        }

        [HttpGet]
        [Route("api/Termin/GetIduciTermin/{KorisnikId}")]
        [ResponseType(typeof(asp_Termin_SelectAll_Result))]
        public IHttpActionResult GetIduciTermin(int KorisnikId)
        {
            DateTime datum = DateTime.Now.Date;
            TimeSpan vrijeme = DateTime.Now.TimeOfDay;

            var termin = db.Termin.Where(x => x.KorisnikId == KorisnikId && (x.Datum > datum || (x.Datum == datum && x.Vrijeme > vrijeme)))
                .OrderBy(x => x.Datum)
                .OrderBy(x => x.Vrijeme)
                .FirstOrDefault();
            
            if (termin == null)
                return NotFound();

            var rezultat = new asp_Termin_SelectAll_Result
            {
                Datum = termin.Datum,
                ImePrezimeKa = termin.Kandidati.Ime + " " + termin.Kandidati.Prezime,
                Vrijeme = termin.Vrijeme.ToString()
            };

            return Ok(rezultat);
        }

        [HttpPost]
        [Route("api/Termin/DaLiJeSlobodanTermin/{p}")]
        [ResponseType(typeof(asp_Termin_DaLiJeSlobodanTermin_Result))]
        public IHttpActionResult DaLiJeSlobodanTermin(int p, Termin termin)
        {
            asp_Termin_DaLiJeSlobodanTermin_Result zauzetiTermin = db.asp_Termin_DaLiJeSlobodanTermin(termin.Datum, termin.Vrijeme, termin.VoziloId, termin.KorisnikId, termin.KandidatId).FirstOrDefault();
            if (zauzetiTermin == null)
            {
                return NotFound();
            }

            return Ok(zauzetiTermin);
        }

        // GET: api/Termin/5
        [ResponseType(typeof(asp_Termin_GetById_Result))]
        public IHttpActionResult GetTermin(int id)
        {
            asp_Termin_GetById_Result termin = db.asp_Termin_GetById(id).FirstOrDefault();
            if (termin == null)
            {
                return NotFound();
            }

            return Ok(termin);
        }

        // PUT: api/Termin/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTermin(int id, Termin termin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termin.TerminId)
            {
                return BadRequest();
            }

            //db.Entry(termin).State = EntityState.Modified;
            Termin t = db.Termin.Find(id);
            t.Datum = termin.Datum;
            t.Vrijeme = termin.Vrijeme;
            t.VoziloId = termin.VoziloId;
            t.KorisnikId = termin.KorisnikId;
            t.KandidatId = termin.KandidatId;
            t.Napomena = termin.Napomena;
            t.IsOdrzan = termin.IsOdrzan;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerminExists(id))
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

        // POST: api/Termin
        [ResponseType(typeof(string))]
        public IHttpActionResult PostTermin(Termin termin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            int brojUplacenihCasova = 0;
            if (db.Upisuje.Where(x => x.KandidatId == termin.KandidatId).Any())
            {
                brojUplacenihCasova = db.Upisuje.Where(x => x.KandidatId == termin.KandidatId).ToList().LastOrDefault().BrojUplacenihCasova ?? 0;
            }


            int brojOdradjenihCasova = db.Termin.Where(x => x.KandidatId == termin.KandidatId).Count(x => x.IsOdrzan == true);

            string poruka = "";
            if (brojOdradjenihCasova >= brojUplacenihCasova)
            {
                poruka = "Nemoguce dodati novi termin. Izvršite uplatu";
            }
            else
            {
                db.Termin.Add(termin);
                db.SaveChanges();
            }



            return Ok(poruka); //CreatedAtRoute("DefaultApi", new { id = termin.TerminId }, termin);
        }

        // DELETE: api/Termin/5
        [ResponseType(typeof(Termin))]
        public IHttpActionResult DeleteTermin(int id)
        {
            Termin termin = db.Termin.Find(id);
            if (termin == null)
            {
                return NotFound();
            }

            db.Termin.Remove(termin);
            db.SaveChanges();

            return Ok(termin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TerminExists(int id)
        {
            return db.Termin.Count(e => e.TerminId == id) > 0;
        }
    }
}
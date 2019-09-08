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
    public class UpisujeController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/Upisuje
        public List<asp_upisuje_SellectAll_Result> GetUpisuje()
        {
            return db.asp_upisuje_SellectAll().ToList();
        }

        // GET: api/Upisuje/5
        [ResponseType(typeof(asp_Upisuje_GetById_Result))]
        public IHttpActionResult GetUpisuje(int id)
        {
            asp_Upisuje_GetById_Result upisuje = db.asp_Upisuje_GetById(id).FirstOrDefault();
            if (upisuje == null)
            {
                return NotFound();
            }

            return Ok(upisuje);
        }
        [HttpGet]
        [Route("api/Upisuje/SearchByName/{name?}")]
        public List<asp_Upisuje_SearchByName_Result> SearchByName(string name = "")
        {
            return db.asp_Upisuje_SearchByName(name).ToList();
        }

        //Upisuje//provjera
        [ResponseType(typeof(asp_Provjera_Uplate_Result))]
        [HttpGet]
        [Route("api/Upisuje/ProvjeraUplate/{KandidatId}/{UplataId}")]
        public IHttpActionResult ProvjeraUplate(int KandidatId, int UplataId)
        {
            return Ok(db.asp_Provjera_Uplate(KandidatId, UplataId).ToList());
        }

        private enum eUplata
        {
            Nula = 1,
            Prva = 2,
            Druga = 3,
            Treca = 4,
            Cijeli = 5
        }


        //Upisuje//provjera nacina placanja
        [ResponseType(typeof(string))]
        [HttpGet]
        [Route("api/Upisuje/ProvjeraNacinaPlacanja/{KandidatId}/{UplataId}")]
        public IHttpActionResult ProvjeraNacinaPlacanja(int KandidatId, int UplataId)
        {
            eUplata zadnjaRata = eUplata.Nula;
            eUplata novaUplata = (eUplata)UplataId;

            List<asp_provjera_nacina_placanja_Result> uplate = db.asp_provjera_nacina_placanja(KandidatId).ToList();
            if (novaUplata == eUplata.Nula)
            {
                if (uplate.Count != 0)
                    return Ok("Potrebno je uplatiti cijeli iznos ili ratu.");

                return Ok("nista");
            }

            foreach (var item in uplate)
            {
                eUplata uplaceno = (eUplata)item.UplataId;
                if (uplaceno == eUplata.Cijeli)
                    return Ok("Korisnik je uplatio čitav iznos");

                if (uplaceno >= eUplata.Nula && uplaceno <= eUplata.Treca && uplaceno > zadnjaRata)
                    zadnjaRata = uplaceno;

            }

            if (novaUplata == eUplata.Cijeli)
            { // Za uplate cijelog iznosa
                if (zadnjaRata != eUplata.Nula)
                    return Ok("Korisnik plaća na rate, nemoguće unijeti čitav iznos");

                return Ok("nista");
            }

            // Za uplate na rate

            if (novaUplata == eUplata.Prva && zadnjaRata >= eUplata.Prva)
                return Ok("Već je unesen prvi iznos!");
            if (novaUplata == eUplata.Druga && zadnjaRata >= eUplata.Druga)
                return Ok("Već je unesen drugi iznos!");
            if (novaUplata == eUplata.Treca && zadnjaRata == eUplata.Treca)
                return Ok("Već je unesen treci iznos!");

            if (novaUplata == eUplata.Druga && zadnjaRata != eUplata.Prva)
                return Ok("Nije uplaćena prva rata");
            if (novaUplata == eUplata.Treca && zadnjaRata != eUplata.Druga)
                return Ok("Nije uplaćena druga rata");

            return Ok("nista");
        }
        // PUT: api/Upisuje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUpisuje(int id, Upisuje upisuje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != upisuje.UpisujeId)
            {
                return BadRequest();
            }

            db.Entry(upisuje).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UpisujeExists(id))
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

        // POST: api/Upisuje
        [ResponseType(typeof(Upisuje))]
        public IHttpActionResult PostUpisuje(Upisuje upisuje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Upisuje.Add(upisuje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = upisuje.UpisujeId }, upisuje);
        }

        // DELETE: api/Upisuje/5
        [ResponseType(typeof(Upisuje))]
        public IHttpActionResult DeleteUpisuje(int id)
        {
            Upisuje upisuje = db.Upisuje.Find(id);
            if (upisuje == null)
            {
                return NotFound();
            }

            db.Upisuje.Remove(upisuje);
            db.SaveChanges();

            return Ok(upisuje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UpisujeExists(int id)
        {
            return db.Upisuje.Count(e => e.UpisujeId == id) > 0;
        }
    }
}
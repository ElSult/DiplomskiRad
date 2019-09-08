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
    public class IzborController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();


        // GET: api/Izbor
        public List<asp_Izbor_SelectAll_Result> GetIzbor()
        {
            return db.asp_Izbor_SelectAll().ToList();
        }

        // GET: api/Izbor/5
        [ResponseType(typeof(asp_Izbor_GetIzborById_Result))]
        public IHttpActionResult GetIzbor(int id)
        {
            asp_Izbor_GetIzborById_Result izbor = db.asp_Izbor_GetIzborById(id).FirstOrDefault();
            if (izbor == null)
            {
                return NotFound();
            }

            return Ok(izbor);
        }

        // PUT: api/Izbor/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIzbor(int id, Izbor izbor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != izbor.IzborId)
            {
                return BadRequest();
            }
            Izbor i = db.Izbor.Find(id);
            i.KorisnikId = izbor.KorisnikId;
            i.Naziv = izbor.Naziv;
            if (izbor.Slika != null)
                i.Slika = izbor.Slika;
            i.DatumIzmjene = DateTime.Now;


            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzborExists(id))
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

        // POST: api/Izbor
        [ResponseType(typeof(Izbor))]
        public IHttpActionResult PostIzbor(Izbor izbor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Izbor.Add(izbor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = izbor.IzborId }, izbor);
        }

        // DELETE: api/Izbor/5
        [ResponseType(typeof(Izbor))]
        public IHttpActionResult DeleteIzbor(int id)
        {
            Izbor izbor = db.Izbor.Find(id);
            if (izbor == null)
            {
                return NotFound();
            }

            db.Izbor.Remove(izbor);
            db.SaveChanges();

            return Ok(izbor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IzborExists(int id)
        {
            return db.Izbor.Count(e => e.IzborId == id) > 0;
        }
    }
}
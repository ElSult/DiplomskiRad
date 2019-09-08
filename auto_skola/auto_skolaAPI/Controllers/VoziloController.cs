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
    public class VoziloController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        public List<asp_Vozilo_SelectAll_Result> GetVozilo()
        {
            return db.asp_Vozilo_SelectAll().ToList();
        }

        // GET: api/Vozilo/5
        [ResponseType(typeof(asp_Vozilo_GetById_Result))]
        public IHttpActionResult GetVozilo(int id)
        {
            asp_Vozilo_GetById_Result vozilo = db.asp_Vozilo_GetById(id).FirstOrDefault();
            if (vozilo == null)
            {
                return NotFound();
            }

            return Ok(vozilo);
        }

        // PUT: api/Vozilo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVozilo(int id, Vozilo vozilo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vozilo.VoziloId)
            {
                return BadRequest();
            }

            db.Entry(vozilo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoziloExists(id))
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

        // POST: api/Vozilo
        [ResponseType(typeof(Vozilo))]
        public IHttpActionResult PostVozilo(Vozilo vozilo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vozilo.Add(vozilo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vozilo.VoziloId }, vozilo);
        }

        // DELETE: api/Vozilo/5
        [ResponseType(typeof(Vozilo))]
        public IHttpActionResult DeleteVozilo(int id)
        {
            Vozilo vozilo = db.Vozilo.Find(id);
            if (vozilo == null)
            {
                return NotFound();
            }

            db.Vozilo.Remove(vozilo);
            db.SaveChanges();

            return Ok(vozilo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VoziloExists(int id)
        {
            return db.Vozilo.Count(e => e.VoziloId == id) > 0;
        }
    }
}
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
    public class VozackiIspitController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/VozackiIspit
        public List<asp_VozackiIspit_SelectAll_Result> GetVozackiIspit()
        {
            return db.asp_VozackiIspit_SelectAll().ToList();
        }


        [Route("api/VozackiIspit/GetByImePrezime/{kandidat?}")]
        [HttpGet]
        public List<asp_VozackiIspit_Result> GetByImePrezime(string kandidat="")
        {
            return db.asp_VozackiIspit(kandidat).ToList();
        }

        // GET: api/VozackiIspit/5
        [ResponseType(typeof(VozackiIspit))]
        public IHttpActionResult GetVozackiIspit(int id)
        {
            VozackiIspit vozackiIspit = db.VozackiIspit.Find(id);
            if (vozackiIspit == null)
            {
                return NotFound();
            }

            return Ok(vozackiIspit);
        }

        // PUT: api/VozackiIspit/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVozackiIspit(int id, VozackiIspit vozackiIspit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vozackiIspit.VozackiIspitId)
            {
                return BadRequest();
            }

            db.Entry(vozackiIspit).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VozackiIspitExists(id))
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

        // POST: api/VozackiIspit
        [ResponseType(typeof(VozackiIspit))]
        public IHttpActionResult PostVozackiIspit(VozackiIspit vozackiIspit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VozackiIspit.Add(vozackiIspit);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vozackiIspit.VozackiIspitId }, vozackiIspit);
        }

        // DELETE: api/VozackiIspit/5
        [ResponseType(typeof(VozackiIspit))]
        public IHttpActionResult DeleteVozackiIspit(int id)
        {
            VozackiIspit vozackiIspit = db.VozackiIspit.Find(id);
            if (vozackiIspit == null)
            {
                return NotFound();
            }

            db.VozackiIspit.Remove(vozackiIspit);
            db.SaveChanges();

            return Ok(vozackiIspit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VozackiIspitExists(int id)
        {
            return db.VozackiIspit.Count(e => e.VozackiIspitId == id) > 0;
        }
    }
}
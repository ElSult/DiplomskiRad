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
    public class PolazeController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/Polaze
        // GET: api/Polaze
        public List<asp_Polaze_SelectAll_Result> GetPolaze()
        {
            return db.asp_Polaze_SelectAll().ToList();
        }

        // GET: api/Polaze/5
        [ResponseType(typeof(Polaze))]
        [Route("api/Polaze/{id}", Name = "GetPolaze")]
        public IHttpActionResult GetPolaze(int id)
        {
            asp_Polaze_GetById_Result polaze = db.asp_Polaze_GetById(id).FirstOrDefault();
            if (polaze == null)
            {
                return NotFound();
            }

            return Ok(polaze);
        }


        [Route("api/Polaze/GetPolazeByKandidatId/{KandidatId}")]
        [HttpGet]
        public List<asp_Polaze_GetPolazeByKandidatId_Result> GetPolazeByKandidatId(int KandidatId)
        {
            List<asp_Polaze_GetPolazeByKandidatId_Result> polaze = db.asp_Polaze_GetPolazeByKandidatId(KandidatId).ToList();
            return polaze;
        }

        [HttpPost]
        [Route("api/Polaze/CustomPostPolaze/{p}")]
        public IHttpActionResult CustomPostPolaze(int p, Polaze obj)
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
            db.Polaze.Add(obj);
            db.SaveChanges();

            return CreatedAtRoute("GetPolaze", new { id = obj.PolazeId }, obj);
        }
        // PUT: api/Polaze/5
        [Route("api/Polaze/{id}")]
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPolaze(int id, Polaze polaze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != polaze.PolazeId)
            {
                return BadRequest();
            }

            db.Entry(polaze).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolazeExists(id))
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

        // POST: api/Polaze
        [ResponseType(typeof(Polaze))]
        public IHttpActionResult PostPolaze(Polaze polaze)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Polaze.Add(polaze);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = polaze.PolazeId }, polaze);
        }

        // DELETE: api/Polaze/5
        [ResponseType(typeof(Polaze))]
        public IHttpActionResult DeletePolaze(int id)
        {
            Polaze polaze = db.Polaze.Find(id);
            if (polaze == null)
            {
                return NotFound();
            }

            db.Polaze.Remove(polaze);
            db.SaveChanges();

            return Ok(polaze);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PolazeExists(int id)
        {
            return db.Polaze.Count(e => e.PolazeId == id) > 0;
        }
    }
}
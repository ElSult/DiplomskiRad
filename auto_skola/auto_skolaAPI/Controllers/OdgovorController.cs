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
    public class OdgovorController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/Odgovor
        public IQueryable<Odgovor> GetOdgovor()
        {
            return db.Odgovor;
        }

        // GET: api/Odgovor/5
        [ResponseType(typeof(Odgovor))]
        public IHttpActionResult GetOdgovor(int id)
        {
            Odgovor odgovor = db.Odgovor.Find(id);
            if (odgovor == null)
            {
                return NotFound();
            }

            return Ok(odgovor);
        }
        [Route("api/Odgovor/GetOdgovoriByPitanjeId/{PitanjeId}")]
        public List<asp_Odgovor_GetOdgovoriByPitanjeId_Result> GetOdgovoriByPitanjeId(int PitanjeId)
        {
            return db.asp_Odgovor_GetOdgovoriByPitanjeId(PitanjeId).ToList();
        }


        [Route("api/Odgovor/DaLiPostojiOdgovor/{PitanjeId}")]
        [HttpGet]
        public IHttpActionResult DaLiPostojiOdgovor(int PitanjeId)
        {
            if (db.asp_Odgovor_DaLiPostojiOdgovor(PitanjeId).Count() != 0)
            {
                return Ok();
            }
            else
                return NotFound();
            // return db.asp_Odgovor_GetOdgovoriByPitanjeId(PitanjeId).ToList();
        }
        // PUT: api/Odgovor/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOdgovor(int id, Odgovor odgovor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != odgovor.OdgovorId)
            {
                return BadRequest();
            }

            Odgovor o = db.Odgovor.Find(id);
            o.IsTacan = odgovor.IsTacan;
            o.Odgovor1 = odgovor.Odgovor1;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdgovorExists(id))
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

        // POST: api/Odgovor
        [ResponseType(typeof(Odgovor))]
        public IHttpActionResult PostOdgovor(Odgovor odgovor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Odgovor.Add(odgovor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = odgovor.OdgovorId }, odgovor);
        }

        // DELETE: api/Odgovor/5
        [ResponseType(typeof(Odgovor))]
        public IHttpActionResult DeleteOdgovor(int id)
        {
            Odgovor odgovor = db.Odgovor.Find(id);
            if (odgovor == null)
            {
                return NotFound();
            }

            db.Odgovor.Remove(odgovor);
            db.SaveChanges();

            return Ok(odgovor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OdgovorExists(int id)
        {
            return db.Odgovor.Count(e => e.OdgovorId == id) > 0;
        }
    }
}
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
    public class OznaceniOdgovoriController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/OznaceniOdgovori
        public List<asp_OznaceniOdgovori_SelectAll_Result> GetOznaceniOdgovori()
        {
            return db.asp_OznaceniOdgovori_SelectAll().ToList();
        }

        // GET: api/OznaceniOdgovori/5
        [ResponseType(typeof(asp_OznaceniOdgovori_GetById_Result))]
        [Route("api/OznaceniOdgovori/{id}", Name = "GetOznaceniOdgovori")]
        public IHttpActionResult GetOznaceniOdgovori(int id)
        {
            asp_OznaceniOdgovori_GetById_Result oznaceniOdgovori = db.asp_OznaceniOdgovori_GetById(id).FirstOrDefault();
            if (oznaceniOdgovori == null)
            {
                return NotFound();
            }

            return Ok(oznaceniOdgovori);
        }

        // PUT: api/OznaceniOdgovori/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOznaceniOdgovori(int id, OznaceniOdgovori oznaceniOdgovori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oznaceniOdgovori.OznacenOdgovorId)
            {
                return BadRequest();
            }

            db.Entry(oznaceniOdgovori).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OznaceniOdgovoriExists(id))
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

        // POST: api/OznaceniOdgovori
        [ResponseType(typeof(OznaceniOdgovori))]
        public IHttpActionResult PostOznaceniOdgovori(OznaceniOdgovori oznaceniOdgovori)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OznaceniOdgovori.Add(oznaceniOdgovori);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oznaceniOdgovori.OznacenOdgovorId }, oznaceniOdgovori);
        }

        // DELETE: api/OznaceniOdgovori/5
        [ResponseType(typeof(OznaceniOdgovori))]
        public IHttpActionResult DeleteOznaceniOdgovori(int id)
        {
            OznaceniOdgovori oznaceniOdgovori = db.OznaceniOdgovori.Find(id);
            if (oznaceniOdgovori == null)
            {
                return NotFound();
            }

            db.OznaceniOdgovori.Remove(oznaceniOdgovori);
            db.SaveChanges();

            return Ok(oznaceniOdgovori);
        }


        [Route("api/OznaceniOdgovori/GetOznaceniOdgovoriByPitanjeId/{PolazeId}/{PitanjeId}")]
        public List<asp_OznaceniOdgovori_GetOznaceniOdgovoriByPitanjeId_Result> GetOznaceniOdgovoriByPitanjeId(int PolazeId, int PitanjeId)
        {
            return db.asp_OznaceniOdgovori_GetOznaceniOdgovoriByPitanjeId(PolazeId, PitanjeId).ToList();
        }

        [HttpGet]
        [Route("api/OznaceniOdgovori/IzbrisiOznaceneOdgovoreByPitanjeId/{PolazeId}/{PitanjeId}")]
        public bool IzbrisiOznaceneOdgovoreByPitanjeId(int PolazeId, int PitanjeId)
        {
            List<OznaceniOdgovori> oznaceniOdgovori = db.OznaceniOdgovori
                .Where(x => x.PolazeId == PolazeId && x.PitanjeId == PitanjeId).ToList();
            if (oznaceniOdgovori.Count > 0)
            {

                foreach (var item in oznaceniOdgovori)
                {
                    db.OznaceniOdgovori.Remove(item);
                }
                db.SaveChanges();
                return true;
            }
            return false;

        }

        [HttpPost]
        [Route("api/OznaceniOdgovori/CustomPostOznaceniOdgovori/{p}")]
        public IHttpActionResult CustomPostOznaceniOdgovori(int p, OznaceniOdgovori obj)
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
            db.OznaceniOdgovori.Add(obj);
            db.SaveChanges();

            return CreatedAtRoute("GetOznaceniOdgovori", new { id = obj.OznacenOdgovorId }, obj);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OznaceniOdgovoriExists(int id)
        {
            return db.OznaceniOdgovori.Count(e => e.OznacenOdgovorId == id) > 0;
        }
    }
}
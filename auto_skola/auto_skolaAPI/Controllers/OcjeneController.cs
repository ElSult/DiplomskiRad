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
    public class OcjeneController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        public IQueryable<Ocjene> GetOcjene()
        {
            return db.Ocjene;
        }

        // GET: api/Ocjene/5
        [ResponseType(typeof(Ocjene))]
        [Route("api/Ocjene/{id}", Name = "GetOcjene")]
        public IHttpActionResult GetOcjene(int id)
        {
            Ocjene ocjene = db.Ocjene.Find(id);
            if (ocjene == null)
            {
                return NotFound();
            }

            return Ok(ocjene);
        }

        [Route("api/Ocjene/DaLiPostojiOcjena/{KandidatId}/{KorisnikId}")]
        [HttpGet]
        public IHttpActionResult DaLiPostojiOcjena(int KandidatId, int KorisnikId)
        {
            if (db.asp_Ocjene_DaLiPostojiOcjena(KandidatId, KorisnikId).Count() != 0)
            {
                return Ok();
            }
            else
                return NotFound();
        }


        [HttpGet]
        [Route("api/Ocjene/GetRejtingByKorisnikId/{KorisnikId}")]
        [ResponseType(typeof(decimal))]
        public IHttpActionResult GetRejtingByKorisnikId(int KorisnikId)
        {
            return Ok(db.asp_Ocjene_GetRejtingByKorisnikId(KorisnikId).FirstOrDefault());
        }


        // PUT: api/Ocjene/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjene(int id, Ocjene ocjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjene.OcjenaId)
            {
                return BadRequest();
            }

            db.Entry(ocjene).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjeneExists(id))
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

        // POST: api/Ocjene
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult PostOcjene(Ocjene ocjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ocjene.Add(ocjene);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjene.OcjenaId }, ocjene);
        }

        // DELETE: api/Ocjene/5
        [ResponseType(typeof(Ocjene))]
        public IHttpActionResult DeleteOcjene(int id)
        {
            Ocjene ocjene = db.Ocjene.Find(id);
            if (ocjene == null)
            {
                return NotFound();
            }

            db.Ocjene.Remove(ocjene);
            db.SaveChanges();

            return Ok(ocjene);
        }


        [HttpPost]
        [Route("api/Ocjene/CustomPostOcjene/{p}")]
        public IHttpActionResult CustomPosOcjene(int p, Ocjene obj)
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
            db.Ocjene.Add(obj);
            db.SaveChanges();

            return CreatedAtRoute("GetOcjene", new { id = obj.OcjenaId }, obj);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjeneExists(int id)
        {
            return db.Ocjene.Count(e => e.OcjenaId == id) > 0;
        }
    }
}
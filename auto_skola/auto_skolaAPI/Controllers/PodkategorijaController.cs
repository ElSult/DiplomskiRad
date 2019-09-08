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
    public class PodkategorijaController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        
        // GET: api/Podkategorija
        public List<asp_Podkategorija_SelectAll_Result> GetPodkategorija()
        {
            return db.asp_Podkategorija_SelectAll().ToList();
        }

        [ResponseType(typeof(List<asp_Podkategorije_GetByKategorijaId_Result>))]
        [Route("api/Podkategorija/GetPodkategorijeByKategorijaId/{KategorijaId}")]
        public IHttpActionResult GetPodkategorijeByKategorijaId(int KategorijaId)
        {
            return Ok(db.asp_Podkategorije_GetByKategorijaId(KategorijaId).ToList());
        }

        // GET: api/Podkategorija/5
        [ResponseType(typeof(Podkategorija))]
        public IHttpActionResult GetPodkategorija(int id)
        {
            asp_Podkategorija_GetById_Result podkategorija = db.asp_Podkategorija_GetById(id).FirstOrDefault();
            if (podkategorija == null)
            {
                return NotFound();
            }

            return Ok(podkategorija);
        }

        // PUT: api/Podkategorija/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPodkategorija(int id, Podkategorija podkategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != podkategorija.PodkategorijaId)
            {
                return BadRequest();
            }

            db.Entry(podkategorija).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PodkategorijaExists(id))
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

        // POST: api/Podkategorija
        [ResponseType(typeof(Podkategorija))]
        public IHttpActionResult PostPodkategorija(Podkategorija podkategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Podkategorija.Add(podkategorija);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = podkategorija.PodkategorijaId }, podkategorija);
        }

        // DELETE: api/Podkategorija/5
        [ResponseType(typeof(Podkategorija))]
        public IHttpActionResult DeletePodkategorija(int id)
        {
            Podkategorija podkategorija = db.Podkategorija.Find(id);
            if (podkategorija == null)
            {
                return NotFound();
            }

            db.Podkategorija.Remove(podkategorija);
            db.SaveChanges();

            return Ok(podkategorija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PodkategorijaExists(int id)
        {
            return db.Podkategorija.Count(e => e.PodkategorijaId == id) > 0;
        }
    }
}
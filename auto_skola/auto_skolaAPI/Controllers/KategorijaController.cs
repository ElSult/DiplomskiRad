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
    public class KategorijaController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        public List<asp_Kategorija_SelectAll_Result> GetKategorija()
        {
            return db.asp_Kategorija_SelectAll().ToList();
        }

        // GET: api/Kategorija/5
        [ResponseType(typeof(asp_Kategorija_GetById_Result))]
        public IHttpActionResult GetKategorija(int id)
        {
            asp_Kategorija_GetById_Result kategorija = db.asp_Kategorija_GetById(id).FirstOrDefault();
            if (kategorija == null)
            {
                return NotFound();
            }

            return Ok(kategorija);
        }

        // PUT: api/Kategorija/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKategorija(int id, Kategorija kategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kategorija.KategorijaId)
            {
                return BadRequest();
            }

            db.Entry(kategorija).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KategorijaExists(id))
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

        // POST: api/Kategorija
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult PostKategorija(Kategorija kategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kategorija.Add(kategorija);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kategorija.KategorijaId }, kategorija);
        }

        // DELETE: api/Kategorija/5
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult DeleteKategorija(int id)
        {
            Kategorija kategorija = db.Kategorija.Find(id);
            if (kategorija == null)
            {
                return NotFound();
            }

            db.Kategorija.Remove(kategorija);
            db.SaveChanges();

            return Ok(kategorija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KategorijaExists(int id)
        {
            return db.Kategorija.Count(e => e.KategorijaId == id) > 0;
        }
    }
}
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
    public class TipPitanjaController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/TipPitanja
        public List<asp_TipPitanja_SelectAll_Result> GetTipPitanja()
        {
            return db.asp_TipPitanja_SelectAll().ToList();
        }

        // GET: api/TipPitanja/5
        [ResponseType(typeof(asp_TipPitanja_GetById_Result))]
        public IHttpActionResult GetTipPitanja(int id)
        {
            asp_TipPitanja_GetById_Result tipPitanja = db.asp_TipPitanja_GetById(id).FirstOrDefault();
            if (tipPitanja == null)
            {
                return NotFound();
            }

            return Ok(tipPitanja);
        }

        // PUT: api/TipPitanja/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipPitanja(int id, TipPitanja tipPitanja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipPitanja.TipPitanjaId)
            {
                return BadRequest();
            }

            db.Entry(tipPitanja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipPitanjaExists(id))
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

        // POST: api/TipPitanja
        [ResponseType(typeof(TipPitanja))]
        public IHttpActionResult PostTipPitanja(TipPitanja tipPitanja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipPitanja.Add(tipPitanja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipPitanja.TipPitanjaId }, tipPitanja);
        }

        // DELETE: api/TipPitanja/5
        [ResponseType(typeof(TipPitanja))]
        public IHttpActionResult DeleteTipPitanja(int id)
        {
            TipPitanja tipPitanja = db.TipPitanja.Find(id);
            if (tipPitanja == null)
            {
                return NotFound();
            }

            db.TipPitanja.Remove(tipPitanja);
            db.SaveChanges();

            return Ok(tipPitanja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipPitanjaExists(int id)
        {
            return db.TipPitanja.Count(e => e.TipPitanjaId == id) > 0;
        }
    }
}
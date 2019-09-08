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
    public class TipIspitaController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/TipIspita
        public List<asp_Tip_Ispita_SelectAll_Result> GetTipIspita()
        {
            return db.asp_Tip_Ispita_SelectAll().ToList();
        }

        // GET: api/TipIspita/5
        [ResponseType(typeof(TipIspita))]
        public IHttpActionResult GetTipIspita(int id)
        {
            TipIspita tipIspita = db.TipIspita.Find(id);
            if (tipIspita == null)
            {
                return NotFound();
            }

            return Ok(tipIspita);
        }

        // PUT: api/TipIspita/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipIspita(int id, TipIspita tipIspita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipIspita.TipIspitaId)
            {
                return BadRequest();
            }

            db.Entry(tipIspita).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipIspitaExists(id))
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

        // POST: api/TipIspita
        [ResponseType(typeof(TipIspita))]
        public IHttpActionResult PostTipIspita(TipIspita tipIspita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipIspita.Add(tipIspita);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipIspita.TipIspitaId }, tipIspita);
        }

        // DELETE: api/TipIspita/5
        [ResponseType(typeof(TipIspita))]
        public IHttpActionResult DeleteTipIspita(int id)
        {
            TipIspita tipIspita = db.TipIspita.Find(id);
            if (tipIspita == null)
            {
                return NotFound();
            }

            db.TipIspita.Remove(tipIspita);
            db.SaveChanges();

            return Ok(tipIspita);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipIspitaExists(int id)
        {
            return db.TipIspita.Count(e => e.TipIspitaId == id) > 0;
        }
    }
}
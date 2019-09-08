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
    public class UplataController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/Uplata
        public List<asp_Uplate_SelectAll_Result> GetUplata()
        {
            return db.asp_Uplate_SelectAll().ToList();
        }

        // GET: api/Uplata/5
        [ResponseType(typeof(asp_Uplata_GetById_Result))]
        public IHttpActionResult GetUplata(int id)
        {
            asp_Uplata_GetById_Result uplata = db.asp_Uplata_GetById(id).FirstOrDefault();
            if (uplata == null)
            {
                return NotFound();
            }

            return Ok(uplata);
        }


        // PUT: api/Uplata/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUplata(int id, Uplata uplata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uplata.UplataId)
            {
                return BadRequest();
            }

            db.Entry(uplata).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UplataExists(id))
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

        // POST: api/Uplata
        [ResponseType(typeof(Uplata))]
        public IHttpActionResult PostUplata(Uplata uplata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uplata.Add(uplata);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uplata.UplataId }, uplata);
        }

        // DELETE: api/Uplata/5
        [ResponseType(typeof(Uplata))]
        public IHttpActionResult DeleteUplata(int id)
        {
            Uplata uplata = db.Uplata.Find(id);
            if (uplata == null)
            {
                return NotFound();
            }

            db.Uplata.Remove(uplata);
            db.SaveChanges();

            return Ok(uplata);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UplataExists(int id)
        {
            return db.Uplata.Count(e => e.UplataId == id) > 0;
        }
    }
}
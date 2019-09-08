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
    public class PitanjeController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();



        public List<Pitanjel_Result> GetPitanje()
        {
            return db.asp_Pitanje_SelectAll().ToList();
        }

        // Get api/Korisnici/SearchByName
        [HttpGet]
        [Route("api/Pitanje/SearchByName/{name?}")]
        public List<Pitanjel_Result> SearchByName(string name = "")
        {
            return db.asp_Pitanje_SelectAll().Where(x => name == null || x.Pitanje1.Contains(name)).ToList();
        }

        // Get api/Korisnici/SearchByTestId
        [HttpGet]
        [Route("api/Pitanje/SearchByTestId/{TestId}")]
        public List<Pitanjel_Result> SearchByTestId(int TestId)
        {
            return db.asp_Pitanje_SelectAll().Where(x => x.TestId == TestId).ToList();
        }

        [HttpGet]
        [ResponseType(typeof(int))]
        [Route("api/Pitanje/GetBrojPitanjaPoTestu/{TestId}")]
        public IHttpActionResult GetBrojPitanjaPoTestu(int TestId)
        {
            return Ok(db.asp_Pitanje_GetBrojPitanjaPoTestu(TestId).FirstOrDefault());
        }

        [ResponseType(typeof(asp_TipPitanja_SelectAll_Result))]
        [Route("api/Pitanje/GetLastPitanje")]
        public IHttpActionResult GetLastPitanje()
        {
            return Ok(db.asp_Pitanje_SelectAll().LastOrDefault());
        }
        [ResponseType(typeof(List<asp_Pitanje_GetPitanjaByTestID_Result>))]
        [Route("api/Pitanje/GetPitanjaByTestID/{TestId}")]
        public IHttpActionResult GetPitanjaByTestID(int TestId)
        {
            return Ok(db.asp_Pitanje_GetPitanjaByTestID(TestId).ToList());
        }

        // GET: api/Pitanje
        //public IQueryable<Pitanje> GetPitanje()
        //{
        //    return db.Pitanje;
        //}

        // GET: api/Pitanje/5
        [ResponseType(typeof(asp_Pitanje_GetById_Result))]
        public IHttpActionResult GetPitanje(int id)
        {
            asp_Pitanje_GetById_Result pitanje = db.asp_Pitanje_GetById(id).FirstOrDefault();
            if (pitanje == null)
            {
                return NotFound();
            }

            return Ok(pitanje);
        }

        // PUT: api/Pitanje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPitanje(int id, Pitanje pitanje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pitanje.PitanjeId)
            {
                return BadRequest();
            }

            // db.Entry(pitanje).State = EntityState.Modified;
            Pitanje p = db.Pitanje.Find(id);
            p.Pitanje1 = pitanje.Pitanje1;
            p.Slika = pitanje.Slika;
            p.SlikaThumb = pitanje.SlikaThumb;
            p.TestId = pitanje.TestId;
            p.TipPitanjaId = pitanje.TipPitanjaId;


            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PitanjeExists(id))
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

        // POST: api/Pitanje
        [ResponseType(typeof(Pitanje))]
        public IHttpActionResult PostPitanje(Pitanje pitanje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pitanje.Add(pitanje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pitanje.PitanjeId }, pitanje);
        }

        // DELETE: api/Pitanje/5
        [ResponseType(typeof(Pitanje))]
        public IHttpActionResult DeletePitanje(int id)
        {
            Pitanje pitanje = db.Pitanje.Find(id);
            if (pitanje == null)
            {
                return NotFound();
            }

            db.Pitanje.Remove(pitanje);
            db.SaveChanges();

            return Ok(pitanje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PitanjeExists(int id)
        {
            return db.Pitanje.Count(e => e.PitanjeId == id) > 0;
        }
    }
}
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
    public class RezultatController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/Rezultat
        public IQueryable<Rezultat> GetRezultat()
        {
            return db.Rezultat;
        }

        // GET: api/Rezultat/5
        [ResponseType(typeof(Rezultat))]
        [Route("api/Rezultat/{id}", Name = "GetRezultat")]
        public IHttpActionResult GetRezultat(int id)
        {
            Rezultat rezultat = db.Rezultat.Find(id);
            if (rezultat == null)
            {
                return NotFound();
            }

            return Ok(rezultat);
        }

        // GET: api/Rezultat/5
        //[ResponseType(typeof(asp_Rezultat_GetRezultatiTestovaReport_Result))]
        //[Route("api/Rezultat/GetRezultatiTestovaReport/{BrojDana?}/{TestId?}")]
        //public IHttpActionResult GetRezultatiTestovaReport(int? BrojDana, int? TestId)
        //{
        //    return Ok(db.asp_Rezultat_GetRezultatiTestovaReport(BrojDana, TestId));
        //}
        // GET: api/Rezultat/5
        [ResponseType(typeof(asp_report_Result))]
        [Route("api/Rezultat/GetReport/{Od?}/{Do?}/{TestId?}/{KandidatId?}")]
        public IHttpActionResult GetReport(DateTime? Od, DateTime? Do, int? TestId, int? KandidatId)
        {
            return Ok(db.asp_report(Od, Do, TestId, KandidatId));
        }
        // GET: api/Rezultat/5
        //KOMENTARISANO 06:37
        //[ResponseType(typeof(asp_Rezultat_GetRezultatiSvihTestovaByKandidatId_Result))]
        //[Route("api/Rezultat/GetRezultatiSvihTestovaByKandidatId/{KandidatId}")]
        //public IHttpActionResult GetRezultatiSvihTestovaByKandidatId(int KandidatId)
        //{
        //    return Ok(db.asp_Rezultat_GetRezultatiSvihTestovaByKandidatId(KandidatId));
        //}

        // PUT: api/Rezultat/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRezultat(int id, Rezultat rezultat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rezultat.RezultatId)
            {
                return BadRequest();
            }

            db.Entry(rezultat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RezultatExists(id))
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

        // POST: api/Rezultat
        [ResponseType(typeof(Rezultat))]
        public IHttpActionResult PostRezultat(Rezultat rezultat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rezultat.Add(rezultat);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rezultat.RezultatId }, rezultat);
        }

        // DELETE: api/Rezultat/5
        [ResponseType(typeof(Rezultat))]
        public IHttpActionResult DeleteRezultat(int id)
        {
            Rezultat rezultat = db.Rezultat.Find(id);
            if (rezultat == null)
            {
                return NotFound();
            }

            db.Rezultat.Remove(rezultat);
            db.SaveChanges();

            return Ok(rezultat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RezultatExists(int id)
        {
            return db.Rezultat.Count(e => e.RezultatId == id) > 0;
        }

        [HttpPost]
        [Route("api/Rezultat/CustomPostRezultat/{p}")]
        public IHttpActionResult CustomPostRezultat(int p, Rezultat obj)
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
            db.Rezultat.Add(obj);
            db.SaveChanges();

            return CreatedAtRoute("GetRezultat", new { id = obj.RezultatId }, obj);
        }
    }
}
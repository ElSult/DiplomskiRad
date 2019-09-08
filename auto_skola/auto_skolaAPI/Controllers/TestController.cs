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
    public class TestController : ApiController
    {
        private auto_skolaEntities db = new auto_skolaEntities();

        // GET: api/Test
        // GET: api/Test
        public List<asp_Test_Select_All_Result> GetTest()
        {
            return db.asp_Test_Select_All().ToList();
        }

        // GET: api/Test
        [HttpGet]
        [Route("api/Test/GetTestPodkategorija/")]
        public List<asp_Test_NazivPodkategorija_Result> GetTestPodkategorija()
        {
            return db.asp_Test_NazivPodkategorija().ToList();
        }


        [HttpGet]
        [Route("api/Test/GetTestByName/{nazivTesta?}")]
        [ResponseType(typeof(asp_Test_Select_All_Result))]
        public List<asp_Test_Select_All_Result> GetTestByName(string nazivTesta = "")
        {
            return db.asp_Test_GetTestByName(nazivTesta).ToList();
        }


        // GET: api/Test/5
        [ResponseType(typeof(asp_Test_GetById_Result))]
        public IHttpActionResult GetTest(int id)
        {
            asp_Test_GetById_Result test = db.asp_Test_GetById(id).FirstOrDefault();
            if (test == null)
            {
                return NotFound();
            }

            return Ok(test);
        }


        [Route("api/Test/GetTestoviByPodkategorijaID/{PodkategorijaId}")]
        public List<asp_Testovi_GetTestoviByPodkategorijaID_Result> GetTestoviByPodkategorijaID(int PodkategorijaId)
        {
            return db.asp_Testovi_GetTestoviByPodkategorijaID(PodkategorijaId).ToList();
        }

        [Route("api/Test/GetRecommendedByKandidatId/{KandidatId}")]
        public List<asp_Testovi_GetRecommendedByKandidatId_Result> GetRecommendedByKandidatId(int KandidatId)
        {
            return db.asp_Testovi_GetRecommendedByKandidatId(KandidatId).ToList();
        }
        [Route("api/Test/GetTestoviByIzbor/{izbor}")]
        public List<asp_Test_GetByIzborNaziv_Result> GetTestoviByIzbor(string izbor)
        {
            return db.asp_Test_GetByIzborNaziv(izbor).ToList();

        }
        [Route("api/Test/DaLiPostojiTestSaPodkategorijom/{Name}/{PodkategorijaId}")]
        [HttpGet]
        public IHttpActionResult DaLiPostojiTestSaPodkategorijom(string Name, int PodkategorijaId)
        {
            if (db.asp_Test_DaLiPostojiTestSaPodkategorijom(Name, PodkategorijaId).Count() != 0)
            {
                return Ok();
            }
            else
                return NotFound();

        }
        [Route("api/Test/GetTestId/{Name}/{PodkategorijaId}")]
        [HttpGet]
        public IHttpActionResult GetTestId(string Name, int PodkategorijaId)
        {
            return Ok(db.asp_Test_GetTestId(Name, PodkategorijaId));


        }

        // PUT: api/Test/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTest(int id, Test test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != test.TestId)
            {
                return BadRequest();
            }

            db.Entry(test).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestExists(id))
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

        // POST: api/Test
        [ResponseType(typeof(Test))]
        public IHttpActionResult PostTest(Test test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Test.Add(test);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = test.TestId }, test);
        }

        // DELETE: api/Test/5
        [ResponseType(typeof(Test))]
        public IHttpActionResult DeleteTest(int id)
        {
            Test test = db.Test.Find(id);
            if (test == null)
            {
                return NotFound();
            }

            db.Test.Remove(test);
            db.SaveChanges();

            return Ok(test);
        }


        // GET: api/Test
        //[HttpGet]
        //[Route("api/Test/RecommendTest/{TestId}")]
        //public List<asp_Testovi_GetTestoviByPodkategorijaID_Result> RecommendTest(int TestId)
        //{
        //   //Recommender r = new Recommender();
        //   // return r.GetSlicneTestove(TestId);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TestExists(int id)
        {
            return db.Test.Count(e => e.TestId == id) > 0;
        }
    }
}
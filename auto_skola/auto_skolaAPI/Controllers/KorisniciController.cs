using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using auto_skolaAPI.Models;
using auto_skolaAPI.Util;

namespace auto_skolaAPI.Controllers
{
    public class KorisniciController : ApiController
    {
        private auto_skolaEntities dm = new auto_skolaEntities();
        [HttpGet]

        public List<asp_Korisnici_SelectAll_Result> GetKorisnici()
        {
            return dm.asp_Korisnici_SelectAll().ToList();
        }


        //GET: api/Korisnici/RecommendInstruktor
        [HttpGet]
        [Route("api/Korisnici/RecommendInstruktor/{kandidatId}")]
        public List<asp_Korisnici_GetById_Result> RecommendInstruktor(int kandidatId)
        {
            Recommender r = new Recommender();
            return r.getInstruktori(kandidatId);
        }


        //GET: api/Korisnici
        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)
        {
            asp_Korisnici_SelectByUsername_Result k = dm.asp_Korisnici_SelectByUsername(username).FirstOrDefault();
           
            if (k == null)
                return NotFound();
            
            return Ok(k);
        }

        //GET: api/Korisnici/GetKorisniciById
        [Route("api/Korisnici/GetKorisniciById/{KorisnikId}")]
        public IHttpActionResult GetKorisniciById(int KorisnikId)
        {
            asp_Korisnici_GetById_Result k = dm.asp_Korisnici_GetById(KorisnikId).FirstOrDefault();

            if (k == null)
                return NotFound();

            return Ok(k);
        }

        //GET: api/Korisnici/GetKorisnikImePrezime
        [Route("api/Korisnici/GetKorisnikImePrezime")]
        public List<asp_Korisnici_SpojenoImePrezime_Result> GetKorisnikImePrezime()
        {
            return dm.asp_Korisnici_SpojenoImePrezime().ToList();

        }

        // Get api/Korisnici/SearchKorisnici
        [HttpGet]
        [Route("api/Korisnici/SearchByName/{name?}")]
        public List<asp_Korisnici_SearchByName_Result> SearchByName(string name="")
        {
            return dm.asp_Korisnici_SearchByName(name).ToList();
        }
        [Route("api/Korisnici/GetRecommendInstruktori")]
        public List<asp_Korisnici_GetRecommendedInstruktori_Result> GetRecommendInstruktori()
        {
            return dm.asp_Korisnici_GetRecommendedInstruktori().ToList();
        }

        // Get api/Korisnici/GetInstruktori
        [Route("api/Korisnici/GetInstruktori")]
        public List<asp_Instruktori_SelectAll_Result> GetInstruktori()
        {
            return dm.asp_Instruktori_SelectAll().ToList();
        }


        // Post api/Korisnici
        public IHttpActionResult PostKorisnik(Korisnici obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                dm.Korisnici.Add(obj);
                foreach (var item in obj.Uloge)
                {
                    KorisniciUloge ku = new KorisniciUloge();
                    ku.KorisnikId = obj.KorisnikId;
                    ku.UlogaId = item.UlogaId;
                    ku.DatumIzmjene = System.DateTime.Now;
                    dm.KorisniciUloge.Add(ku);
                }
                dm.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex.InnerException), HttpStatusCode.Conflict);
                }
                else
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            return CreatedAtRoute("DefaultApi",new { id=obj.KorisnikId},obj);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }


        // Put api/Korisnici
        [HttpPut]
        //[ResponseType(typeof(void))]
        [Route("api/Korisnici/{id}")]
        public IHttpActionResult PutKorisnici(int id,Korisnici k)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (id != k.KorisnikId)
                return BadRequest();
            Korisnici pronadjeni = dm.Korisnici.Find(id);
            pronadjeni.Ime = k.Ime;
            pronadjeni.Prezime = k.Prezime;
            pronadjeni.Adresa = k.Adresa;
            pronadjeni.Telefon = k.Telefon;
            pronadjeni.Email = k.Email;
            pronadjeni.KorisnickoIme = k.KorisnickoIme;
            pronadjeni.Status = k.Status;
            pronadjeni.Napomena = k.Napomena;
            pronadjeni.LozinkaSalt = k.LozinkaSalt;
            pronadjeni.LozinkaHash = k.LozinkaHash;
            pronadjeni.DatumPrijave = k.DatumPrijave;
            dm.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dm.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

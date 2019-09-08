using auto_skolaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace auto_skolaAPI.Controllers
{
    public class UlogeController : ApiController
    {
        private auto_skolaEntities dm = new auto_skolaEntities();

        public List<asp_Uloge_SelectAll_Result> GetUloge()
        {
            return dm.asp_Uloge_SelectAll().ToList();
        }

        [Route("api/Uloge/GetUlogeByKorisnikId/{id}")]
        public List<asp_Uloge_GetUlogeByKorisnikId_Result> GetUlogeByKorisnikId(int id)
        {
            return dm.asp_Uloge_GetUlogeByKorisnikId(id).ToList();

        }
    }
}

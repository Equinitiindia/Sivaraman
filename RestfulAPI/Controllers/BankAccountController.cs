using RestfulAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace RestfulAPI.Controllers
{
    [Authorize]
    public class BankAccountController : ApiController
    {
        // GET api/values
        public JsonResult<List<Account>> Get()
        {
            var records=Startup.Repository.GetAll();
            return Json(records);
        }

        // GET api/values/5
        public JsonResult<Account> Get(int id)
        {
            return Json(Startup.Repository.GetByApplicationId(id));
        }

        // POST api/values
        public void Post([FromBody]Account value)
        {
            Startup.Repository.Create(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Account value)
        {
            value.ApplicationId = id;
            Startup.Repository.Update(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Startup.Repository.Delete(id);
        }
    }
}

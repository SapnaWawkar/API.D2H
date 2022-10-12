using API.D2H.Models;
using BL.D2H.Interfaces;
using Models.D2H.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.D2H.Controllers
{
    public class PackagesController : ApiController
    {
        private IPackageBL businessLogic;
        public PackagesController(IPackageBL packageBL)
        {
            this.businessLogic = packageBL;
        }

        // GET api/<controller>
       public List<Package> Get()
        {
            return businessLogic.GetAll();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
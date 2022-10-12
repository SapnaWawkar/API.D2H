using BL.D2H.Interfaces;
using Models.D2H.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.D2H.Controllers
{
    public class CustomerController :ApiController
    {
        private ICustomerBL businessLogic;
        public CustomerController(ICustomerBL customerBL)
        {
            this.businessLogic = customerBL;
        }
        public List<Customer> Get(string CustomerName)
        {
            return businessLogic.GetAllCustomerWithName(CustomerName);
        }


        // POST api/values
        public void Post([FromBody] AddNewCustomer obj)
        {
            businessLogic.AddNewCustomer(obj);
        }

        
    }
}
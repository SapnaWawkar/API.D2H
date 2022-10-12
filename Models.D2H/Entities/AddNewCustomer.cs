using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.D2H.Entities
{
    public class AddNewCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int ConnectionStatusId { get; set; }
        public int PackageId { get; set; }
        public int GroupId { get; set; }
        public int AreaId { get; set; }
    }
}

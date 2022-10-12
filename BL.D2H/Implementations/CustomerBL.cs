using BL.D2H.Interfaces;
using Models.D2H.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.D2H.Implementations
{
    public class CustomerBL : ICustomerBL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;
        public List<Customer> GetAllCustomerWithName(string Customername)
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"EXECUTE [dbo].[GetCustomerWithname] '{Customername}'", connection);
                List<Customer> list = new List<Customer>();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer cust = new Customer();
                    cust.Id = (int)reader[0];
                    cust.Name=(string)reader[1];
                    cust.Package=(string)reader[2];
                    cust.Group = (string)reader[3];
                    cust.Area = (string)reader[4];

                    customers.Add(cust);

                }
                connection.Close();
                
            }
            return customers;
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void AddNewCustomer(AddNewCustomer obj)
        {
            List<AddNewCustomer> customers = new List<AddNewCustomer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"EXECUTE [dbo].[AddNewCustomer] '{obj.FirstName}','{obj.LastName}'" +
                    $",'{obj.Username}','{obj.Password}','{obj.ConnectionStatusId}','{obj.PackageId}'," +
                    $"'{obj.GroupId}','{obj.AreaId}'", connection);
                
                connection.Close();

            }
            
        }
    }
}

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
    public class PackageBL : IPackageBL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["dev"].ConnectionString;
        public List<Package> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"select p.[Id],p.[Package] from [dbo].Package p", connection);
                List<Package> list = new List<Package>();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Package package = new Package();
                    package.Id = reader.GetInt32(0);
                    package.Name = reader.GetString(1);
                    list.Add(package);

                }
                connection.Close();
                return list;
            }
        }
    }
}

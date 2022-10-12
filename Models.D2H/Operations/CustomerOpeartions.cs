using Models.D2H.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.D2H.Operations
{
    public class CustomerOpeartions
    {
        private static string connectionString = "Data Source=LAPTOP-QQJKA00R;Initial Catalog=Sapna;Integrated Security=True";
        public static List<Package> GetAllPackages()
        {
            List<Package> packages = new List<Package>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select p.[Id],p.[Package] from [dbo].Package p", connection);
                List<Package> list = new List<Package>();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Package package = new Package();
                    package.Id = reader.GetInt32(0);
                    package.Name = reader.GetString(1);
                    packages.Add(package);

                }
                connection.Close();
                
            }
            return packages;
        }
    }
}

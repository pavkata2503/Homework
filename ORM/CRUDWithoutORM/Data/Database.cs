using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03.OOP.Data
{
    class Database
    {
        //Стринг
        private static string connectionString = "Server=LAPTOP-POJ3LVD0;Initial Catalog=Warehouse;Integrated Security=True;TrustServerCertificate=True;Pooling=False";
        //Създаване на нова конекция
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

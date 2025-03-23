using _11._03.OOP.Data;
using Microsoft.Data.SqlClient;
using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static NHibernate.Engine.Query.CallableParser;

namespace _11._03.OOP.Controllers
{
    class BuyersData
    {
        private static string _connectionString = "Server=LAPTOP-POJ3LVD0;Initial Catalog=Warehouse;Integrated Security=True;TrustServerCertificate=True;Pooling=False";
        public void Add(Buyer buyer)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Buyers (Name, Address, Phone, Email) VALUES(@name, @address, @phone, @email)", connection);
                command.Parameters.AddWithValue("name", buyer.Name);
                command.Parameters.AddWithValue("address", buyer.Address);
                command.Parameters.AddWithValue("phone", buyer.Phone);
                command.Parameters.AddWithValue("email", buyer.Email);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }


        }

        //public void Add<T>(T entity) where T : Buyer
        //{
        //    using (var connection = Database.GetConnection())
        //    {
        //        var command = new SqlCommand(
        //            "INSERT INTO Buyers (Name, Address, Phone, Email) " +
        //            "VALUES(@name, @address, @phone, @email)", connection);

        //        command.Parameters.AddWithValue("name", entity.Name);
        //        command.Parameters.AddWithValue("address", entity.Address);
        //        command.Parameters.AddWithValue("phone", entity.Phone);
        //        command.Parameters.AddWithValue("email", entity.Email);

        //        connection.Open();
        //        command.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //}

        public void BuyProduct(int buyerId, int productId)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Buyers SET ProductId = @ProductId WHERE Id = @BuyerId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.Parameters.AddWithValue("@BuyerId", buyerId);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void DeleteBuyer(int buyerId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Buyers WHERE Id = @BuyerId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BuyerId", buyerId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

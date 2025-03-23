using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using NHibernate.Mapping;
using Unipluss.Sign.ExternalContract.Entities;
using _11._03.OOP.Data;

namespace _11._03.OOP.Controllers
{
    class ProdutData
    {
        public void Add(Product product)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Products (Name, Price, Description) VALUES(@name, @price, @description)", connection);
                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("description", product.Description);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete(int productId)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                var updateBuyersCommand = new SqlCommand(
                    "UPDATE Buyers SET ProductId = NULL WHERE ProductId = @productId",
                    connection);
                updateBuyersCommand.Parameters.AddWithValue("@productId", productId);
                updateBuyersCommand.ExecuteNonQuery();

                var deleteProductCommand = new SqlCommand(
                    "DELETE FROM Products WHERE Id = @productId",
                    connection);
                deleteProductCommand.Parameters.AddWithValue("@productId", productId);
                deleteProductCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}

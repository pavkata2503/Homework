using _11._03.OOP.Controllers;
using _11._03.OOP.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string conectionString = "Server=LAPTOP-POJ3LVD0;Integrated Security=True;TrustServerCertificate=True;Pooling=False";
            SqlConnection conectionConnection = new SqlConnection(conectionString);

            using (var db = new Warehouse())
            {
                if (db.Database.EnsureCreated())
                {
                    Console.WriteLine("Database  Created!");
                }
                else
                {
                    Console.WriteLine("Database already exists");
                }
            }
            ProdutData produtData = new ProdutData();
            Product product = new Product { Id = 1, Name = "Laptop", Description = "Lenovo", Price = 1000 };
            Product product1 = new Product { Id = 2, Name = "Komuter", Description = "Asus", Price = 2000 };
            Product product2 = new Product { Id = 3, Name = "Microvolnova", Description = "Philips", Price = 480 };

            produtData.Add(product);
            produtData.Add(product1);
            produtData.Add(product2);

            BuyersData buyerData = new BuyersData();
            Buyer buyer = new Buyer
            {
                Id = 1,
                Name = "Kaloyan",
                Address = "Plovdiv",
                Phone = "0884390393",
                Email = "pavkata@gmail.com"
            };
            Buyer buyer1 = new Buyer
            {
                Id = 2,
                Name = "Ivan",
                Address = "Pernik",
                Phone = "0884701375",
                Email = "veneta@gmail.com"
            };
            buyerData.Add(buyer);
            buyerData.Add(buyer1);


            buyerData.BuyProduct(1, 2);
            //buyerData.DeleteBuyer(1); 

            //produtData.Delete(1); 
        }


    }

    
}

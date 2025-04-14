using Microsoft.EntityFrameworkCore;
using CarManifacute.Models;
using System;
using System.Text;

namespace CarManifacute.Data
{
    public class CarDbContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-POJ3LVD0;Initial Catalog=arManifacture;Integrated Security=True;TrustServerCertificate=True;Pooling=False");
        }

        public string CompareCars(int carId1, int carId2)
        {
            var car1 = Cars
                .Include(c => c.Model)
                .Include(c => c.Engine)
                .FirstOrDefault(c => c.Id == carId1);

            var car2 = Cars
                .Include(c => c.Model)
                .Include(c => c.Engine)
                .FirstOrDefault(c => c.Id == carId2);
            int car1point = 0;
            int car2point = 0;
            if (car1 == null || car2 == null)
            {
                return "Една или и двете коли не са намерени в базата данни.";
            }
            Console.WriteLine($"СРАВНЕНИЕ МЕЖДУ {car1.Brand} {car1.Model.Name} И {car2.Brand} {car2.Model.Name}");
            Console.WriteLine(" =====================================================");

            Console.WriteLine("1. МОЩНОСТ НА ДВИГАТЕЛЯ:");
            string powerWinner = "";
            double powerDiff = car1.Engine.HoursePower - car2.Engine.HoursePower;
            if (powerDiff > 0)
            {
                 powerWinner = $"{car1.Brand} {car1.Model.Name}";
                Console.WriteLine(powerWinner);
                car1point++;
            }
            else
            {
                powerWinner = $"{car2.Brand} {car2.Model.Name}";
                Console.WriteLine(powerWinner);
                car2point++;
            }
            Console.WriteLine($"   {car1.Brand} {car1.Model.Name}: {car1.Engine.HoursePower} к.с.");
            Console.WriteLine($"   {car2.Brand} {car2.Model.Name}: {car2.Engine.HoursePower} к.с.");
            Console.WriteLine($"   Разлика: {Math.Abs(powerDiff)} к.с.");
            Console.WriteLine($"   По-мощен автомобил: {powerWinner}");
            Console.WriteLine();

            Console.WriteLine("2. РАЗХОД НА ГОРИВО:");
            double consumptionDiff = car1.Engine.FuelConsumption - car2.Engine.FuelConsumption;
            string consumptionWinner = "";
            if (consumptionDiff > 0)
            {
                consumptionWinner = $"{car2.Brand} {car2.Model.Name}";
                car2point++;
            }
            else
            {
                consumptionWinner = $"{car1.Brand} {car1.Model.Name}";
                car1point++;
            }
            Console.WriteLine($"   {car1.Brand} {car1.Model.Name}: {car1.Engine.FuelConsumption:F1} л/100км");
            Console.WriteLine($"   {car2.Brand} {car2.Model.Name}: {car2.Engine.FuelConsumption:F1} л/100км");
            Console.WriteLine($"   Разлика: {Math.Abs(consumptionDiff):F1} л/100км");
            Console.WriteLine($"   По-икономичен автомобил: {consumptionWinner}");
            Console.WriteLine();
            if (car1point>car2point)
            {
                return $"{car1.Brand} {car1.Model.Name} е по-добрият автомобил!";
            }
            else if (car1point < car2point)
            {
                return $"{car2.Brand} {car2.Model.Name} е по-добрият автомобил!";
            }
            else
            {
                return "Двата автомобила са равностойни!";
            }


        }

        public void DemonstrateCarComparison(int carId1, int carId2)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("СРАВНЕНИЕ НА АВТОМОБИЛИ");
            Console.WriteLine("=================================================");
            
            string comparison = CompareCars(carId1, carId2);
            Console.WriteLine(comparison);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbSeeder.ExampleSeed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
} 
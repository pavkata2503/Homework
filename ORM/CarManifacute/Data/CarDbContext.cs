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
            optionsBuilder.UseSqlServer("Server=LAPTOP-POJ3LVD0;Initial Catalog=AirCompanySystem;Integrated Security=True;TrustServerCertificate=True;Pooling=False");
        }

        /// <summary>
        /// Сравнява две коли по различни критерии и връща подробен анализ
        /// </summary>
        /// <param name="carId1">ID на първата кола</param>
        /// <param name="carId2">ID на втората кола</param>
        /// <returns>Текстово сравнение между колите</returns>
        public string CompareCars(int carId1, int carId2)
        {
            // Зареждаме колите заедно с техните модели и двигатели
            var car1 = Cars
                .Include(c => c.Model)
                .Include(c => c.Engine)
                .FirstOrDefault(c => c.Id == carId1);

            var car2 = Cars
                .Include(c => c.Model)
                .Include(c => c.Engine)
                .FirstOrDefault(c => c.Id == carId2);

            if (car1 == null || car2 == null)
            {
                return "Една или и двете коли не са намерени в базата данни.";
            }
            Console.WriteLine($"СРАВНЕНИЕ МЕЖДУ {car1.Brand} {car1.Model.Name} И {car2.Brand} {car2.Model.Name}");
            Console.WriteLine(" =====================================================");

            // 1. Сравнение по мощност на двигателя
            Console.WriteLine("1. МОЩНОСТ НА ДВИГАТЕЛЯ:");
            string powerWinner = "";
            double powerDiff = car1.Engine.HoursePower - car2.Engine.HoursePower;
            if (powerDiff > 0)
            {
                 powerWinner = $"{car1.Brand} {car1.Model.Name}";
                Console.WriteLine(powerWinner);
            }
            else
            {
                powerWinner = $"{car2.Brand} {car2.Model.Name}";
                Console.WriteLine(powerWinner);
            }
            Console.WriteLine($"   {car1.Brand} {car1.Model.Name}: {car1.Engine.HoursePower} к.с.");
            Console.WriteLine($"   {car2.Brand} {car2.Model.Name}: {car2.Engine.HoursePower} к.с.");
            Console.WriteLine($"   Разлика: {Math.Abs(powerDiff)} к.с.");
            Console.WriteLine($"   По-мощен автомобил: {powerWinner}");
            Console.WriteLine();

            // 2. Сравнение по разход на гориво
            Console.WriteLine("2. РАЗХОД НА ГОРИВО:");
            double consumptionDiff = car1.Engine.FuelConsumption - car2.Engine.FuelConsumption;
            string consumptionWinner = consumptionDiff < 0 ? $"{car1.Brand} {car1.Model.Name}" : $"{car2.Brand} {car2.Model.Name}";
            Console.WriteLine($"   {car1.Brand} {car1.Model.Name}: {car1.Engine.FuelConsumption:F1} л/100км");
            Console.WriteLine($"   {car2.Brand} {car2.Model.Name}: {car2.Engine.FuelConsumption:F1} л/100км");
            Console.WriteLine($"   Разлика: {Math.Abs(consumptionDiff):F1} л/100км");
            Console.WriteLine($"   По-икономичен автомобил: {consumptionWinner}");
            Console.WriteLine();

            return comparison.ToString();
        }

        /// <summary>
        /// Демонстрира сравнението на два автомобила и отпечатва резултата
        /// </summary>
        /// <param name="carId1">ID на първата кола</param>
        /// <param name="carId2">ID на втората кола</param>
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
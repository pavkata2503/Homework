namespace Pizza_Service
{
    public class CashRegister
    {
        private readonly Dictionary<string, List<Pizza>> _dailySales = new Dictionary<string, List<Pizza>>();

        public void AddOrder(Pizza pizza)
        {
            if (!_dailySales.ContainsKey(pizza.OrderDate))
            {
                _dailySales[pizza.OrderDate] = new List<Pizza>();
            }
            
            _dailySales[pizza.OrderDate].Add(pizza);
        }

        public void DailyReport()
        {
            Console.WriteLine();
            Console.WriteLine("Cash register reset:");
            
            foreach (var day in _dailySales.Keys)
            {
                var dailyPizzas = _dailySales[day];

                Console.WriteLine($"{day}");
                Console.WriteLine($"Total pizzas {dailyPizzas.Sum(p => p.Quantity)}");
                Console.WriteLine($"Margarita {dailyPizzas.Where(p => p is Margarita).Sum(p => p.Quantity)}");
                Console.WriteLine($"Boss` Pizza {dailyPizzas.Where(p => p is BossPizza).Sum(p => p.Quantity)}");
                Console.WriteLine($"Total Income = {dailyPizzas.Sum(p => p.CalculatePrice())}");
                Console.WriteLine();
            }
        }
    }
}

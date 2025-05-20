namespace Pizza_Service
{
    public class Margarita : Pizza
    {
        private Dictionary<string, decimal> _prices = new()
        {
            { "small", 5 },
            { "medium", 10 },
            { "large", 15 }
        };

        public override string GetName() 
        {
            return "Margarita"; 
        }

        public override void Prepare()
        {
            Console.WriteLine($"Margarita preparing...");
            Console.WriteLine($"Pizza dough {Quantity}*{GetAmount()} ={Quantity * GetAmount()}gr");
            Console.WriteLine($"Tomatoes {Quantity}*1 ={Quantity}");
            Console.WriteLine($"Total: ${CalculatePrice()}");
        }

        public override decimal CalculatePrice()
        {
            return _prices[Size.ToLower()] * Quantity;
        }
    }
}

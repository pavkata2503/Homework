namespace Pizza_Service
{
    public class BossPizza : Pizza
    {
        private readonly Dictionary<string, decimal> _prices = new()
        {
            { "small", 20 },
            { "medium", 25 },
            { "large", 30 }
        };

        public override string GetName() 
        {
            return "Boss' Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Boss` Pizza preparing...");
            Console.WriteLine($"Pizza dough {Quantity}*{GetAmount()} ={Quantity * GetAmount()}gr");
            Console.WriteLine($"Ham {Quantity}*100 ={Quantity * 100}gr");
            Console.WriteLine($"Total: ${CalculatePrice()}");
        }

        public override decimal CalculatePrice()
        {
            return _prices[Size.ToLower()] * Quantity;
        }
    }
}

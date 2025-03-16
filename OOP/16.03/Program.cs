namespace _16._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair usd_euro = new Pair(1.96, "USD/EUR");
            Pair bgn_usd = new Pair(0.80, "BGN/USD");
            Pair euro_bgn = new Pair(1.96, "EUR/BGN");
            Console.WriteLine("Какъв потребител ще добавиш, Normal или Special");
            string customerType = Console.ReadLine();
            if (customerType=="Normal")
            {
                Console.WriteLine("Въведи Име");
                string name = Console.ReadLine();
                Console.WriteLine("Въведи Баланс в лева");
                double balance = double.Parse(Console.ReadLine());
                NormalCustomer normalCustomer1 = new NormalCustomer(name, balance);
                Console.WriteLine("Към каква валута искаш да си обърнеш парите. USD, EURO");
                string currency = Console.ReadLine();
                if (currency == "USD")
                {
                    normalCustomer1.ChangeValues(normalCustomer1.Balance, usd_euro.exchangeRate);
                }
                else if(currency == "EURO")
                {
                    normalCustomer1.ChangeValues(normalCustomer1.Balance, euro_bgn.exchangeRate);
                }
                Console.WriteLine(normalCustomer1.ToString());
            }
            else if (customerType == "Special")
            {
                Console.WriteLine("Въведи Име");
                string name = Console.ReadLine();
                Console.WriteLine("Въведи Баланс");
                double balance = double.Parse(Console.ReadLine());
                SpecialCustomer specialCustomer1 = new SpecialCustomer(name, balance);
                Console.WriteLine("Към каква валута искаш да си обърнеш парите. USD, EURO , GBN");
                string currency = Console.ReadLine();
                if (currency == "USD")
                {
                    specialCustomer1.ChangeValues(specialCustomer1.Balance, usd_euro.exchangeRate);
                }
                else if (currency == "EURO")
                {
                    specialCustomer1.ChangeValues(specialCustomer1.Balance, euro_bgn.exchangeRate);
                }
                Console.WriteLine(specialCustomer1.ToString());
            }
            

               

        }
    }
}

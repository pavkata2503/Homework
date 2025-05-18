namespace Pizza_Service
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string type, int quantity, string size, string date)
        {
            string lowerSize = size.ToLower();
            string[] validSizes = { "small", "medium", "large" };

            if (!validSizes.Contains(lowerSize))
            {
                throw new ArgumentException("Invalid pizza size");
            }

            Pizza pizza;

            switch (type)
            {
                case "Margarita":
                    pizza = new Margarita();
                    break;

                case "Boss'Pizza":
                    pizza = new BossPizza();
                    break;

                default:
                    throw new ArgumentException("Invalid pizza type");
            }

            pizza.Size = size;
            pizza.Quantity = quantity;
            pizza.OrderDate = date;

            return pizza;
        }
    }
}

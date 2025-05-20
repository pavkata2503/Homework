namespace Pizza_Service
{
    public class PizzaMaker
    {
        public static Pizza CreatePizza(string type, int quantity, string size, string date)
        {
            string lowerSize = size.ToLower();
            string[] validSizes = { "small", "medium", "large" };
            string lowertype = type.ToLower();
            if (!validSizes.Contains(lowerSize))
            {
                throw new ArgumentException("Invalid pizza size");
            }

            Pizza pizza;

            switch (lowertype)
            {
                case "margarita":
                    pizza = new Margarita();
                    break;

                case "boss'pizza":
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

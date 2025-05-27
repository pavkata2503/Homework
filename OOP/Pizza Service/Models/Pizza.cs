using Pizza_Service.Interfaces;

namespace Pizza_Service.Models
{
    internal abstract class Pizza : IPizza
    {
        public string Size { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        protected Pizza()
        {
                OrderDate = DateTime.Now; // Set the order date to the current date and time by default
        }

        public abstract string GetName();
        public abstract void Prepare();
        public abstract decimal CalculatePrice();

        public int GetAmount()
        {
            string sizeLower = Size.ToLower();

            if (sizeLower == "small")
            {
                return 300;
            }
            else if (sizeLower == "medium")
            {
                return 500;
            }
            else if (sizeLower == "large")
            {
                return 800;
            }
            else
            {
                return 0;
            }
        }

    }
}

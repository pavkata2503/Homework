namespace Pizza_Service
{
    public abstract class Pizza
    {
        public string Size { get; set; }
        public int Quantity { get; set; }
        public string OrderDate { get; set; }

        public abstract string GetName();
        public abstract void Prepare();
        public abstract decimal CalculatePrice();

        protected int GetAmount()
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

namespace DrawingShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing();
            string shape = "rectangle";
            string color = "red";
            int width = 15;
            int height = 5;
            drawing.DrawShape(shape, color, width, height);

            shape = "square";
            color = "blue";
            width = 8;
            height = 8;
            drawing.DrawShape(shape, color, width, height);
        }
    }
}

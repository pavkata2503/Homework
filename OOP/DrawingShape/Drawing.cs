using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShape
{
    internal class Drawing
    {
        public void DrawShape(string shape, string color, int width, int height)
        {
            // Declare a variable to hold the parsed color
            ConsoleColor userColor;

            // Try parsing the input string into a ConsoleColor enum
            Enum.TryParse(color, true, out userColor);
            // Set the console text color
            Console.ForegroundColor = userColor;
            if (shape == "rectangle")
            {
                // Draw top edge
                for (int x = 0; x < width; x++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                // Draw middle rows (hollow)
                for (int y = 1; y < height - 1; y++)
                {
                    Console.Write('*');
                    for (int x = 1; x < width - 1; x++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write('*');
                    Console.WriteLine();
                }

                for (int x = 0; x < width; x++)
                    Console.Write('*');
                Console.WriteLine();

            }
            else if (shape == "square")
            {

                // Try parsing the input string into a ConsoleColor enum
                Enum.TryParse(color, true, out userColor);
                    // Set the console text color
                    Console.ForegroundColor = userColor;

                int size = 5;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    Console.WriteLine();
                }

                // Reset the color to default
                Console.ResetColor();

            }
        }
        public void DrawShape(string shape, string formula)
        {

        }
    }
}

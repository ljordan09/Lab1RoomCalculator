using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_10._24._17
{
    class Program
    {
        static void Main(string[] args)
        {

            double l, w, h, perimeter, area, volume;
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Enter the length of the rectangle (in feet) : ");
                l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle (in feet) : ");
                w = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of the rectangle (in feet): ");
                h = Convert.ToDouble(Console.ReadLine());
                
                perimeter = 2 * (l + w);
                area = l * w;
                volume = l * w * h;
                Console.WriteLine("Perimeter of Rectangle : {0}  ft. ", perimeter);
                Console.WriteLine("Area of Rectangle : {0} square ft. ", area);
                Console.WriteLine("Volume of Rectangle : {0} cubic ft. ", volume);

                Console.WriteLine("Would you like to run the program again? (yes or no): ");
                string doAgain = Console.ReadLine();

                if (doAgain.ToUpper() == "YES" || doAgain.ToLower() == "yes" || doAgain.ToLower() == "Yes" || doAgain.ToLower() == "y" || doAgain.ToUpper() == "Y")
                {
                    repeat = true;
                }
                
                else if (doAgain.ToUpper() == "NO" || doAgain.ToLower() == "no" || doAgain.ToLower() == "No" || doAgain.ToLower() == "n" || doAgain.ToUpper() == "N")
                {
                    repeat = false;
                }
                else
                {
                    repeat = false;
                }
            }

            Console.ReadKey();
        }
    }
}

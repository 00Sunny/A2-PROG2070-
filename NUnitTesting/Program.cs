using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
{
    public class Program
    {
        public static void Main()
        {
            int lengthValue = 0, widthValue = 0;
            string optionNumber = "";
            
            Console.WriteLine("Please enter the length of the rectangle: ");

            do
            {
                if (!int.TryParse(Console.ReadLine(), out lengthValue))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                }
                else
                {
                    if (lengthValue <= 0)
                    {
                        Console.WriteLine("The length must be an integer greater than zero!");
                    }
                }
            } while (lengthValue <= 0);


            Console.WriteLine("Please enter the width of the rectangle: ");

            do
            {
                if (!int.TryParse(Console.ReadLine(), out widthValue))
                {
                    Console.WriteLine("Please enter a valid integer value!");
                }
                else
                {
                    if (widthValue <= 0)
                    {
                        Console.WriteLine("The width must be an integer greater than zero!");
                    }
                }
            } while (widthValue <= 0);

            Rectangle rectangle = new Rectangle(lengthValue, widthValue);

            do
            {
                Console.WriteLine("1. Get Rectangle Length\n2. Change Rectangle Length\n3. Get Rectangle Width\n4. Change Rectangle Width"
                                   + "\n5. Get Rectangle Perimeter\n6. Get Rectangle Area\n7. Exit");
                Console.WriteLine("Please enter one of 7 options: ");
                optionNumber = Console.ReadLine();


                bool checkForLength = true;
                bool checkForWidth = true;
                switch (optionNumber)
                {
                    case "1":
                        Console.WriteLine("The length of rectangle is " + rectangle.GetLength());
                        break;
                    case "2":
                        Console.Write("Please enter a new length of rectangle: ");
                        do
                        {
                            
                            if (!int.TryParse(Console.ReadLine(), out lengthValue) || lengthValue <= 0)
                            {
                                Console.WriteLine("It's invalid! It must be an integer greater than Zero.\nPlease try it again.");
                                checkForLength = false;
                            }
                            else
                            {
                                Console.WriteLine("It has been changed to " + rectangle.SetLength(lengthValue));
                                checkForLength = true;
                            }
                        } while (!checkForLength);                                    
                        break;
                    case "3":
                        Console.WriteLine("The width of rectangle is " + rectangle.GetWidth());
                        break;
                    case "4":
                        Console.Write("Please enter a new length of rectangle: ");
                        do
                        {
                            if (!int.TryParse(Console.ReadLine(), out widthValue) || widthValue <= 0)
                            {
                                Console.WriteLine("It's invalid! It must be an integer greater than Zero.\nPlease try it again.");
                                checkForWidth = false;
                            }
                            else
                            {
                                Console.WriteLine("It has been changed to " + rectangle.SetWidth(widthValue));
                                checkForWidth = true;
                            }
                        } while (!checkForWidth);                                                    
                        break;
                    case "5":
                        Console.WriteLine("The perimeter of rectangle is " + rectangle.GetPerimeter());
                        break;
                    case "6":
                        Console.WriteLine("The area of rectangle is " + rectangle.GetArea());
                        break;
                    default:
                        break;
                }

            } while (optionNumber != "7");

            Console.ReadLine();

        }
    }
}
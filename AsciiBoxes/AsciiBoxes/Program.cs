using System;

namespace AsciiBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            int w;
            int h;
            Boolean repeat = true;
            string response;

            //loop to keep the program running if more boxes are needed
            while (repeat)
            {
                //try catch to stop invalid inputs
                try
                {
                    //assigning user inputs
                    Console.WriteLine("Please Enter the Width of the Box");
                    w = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please Enter the Height of the Box");
                    h = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    //showing error and resetting variables
                    Console.WriteLine("Please Enter a Valid Number");
                    w = 0;
                    h = 0;
                }

                //nested for loops to iterate through the height and the width
                for (int heightCount = 0; heightCount < h; heightCount++)
                {

                    for (int widthCount = 0; widthCount < w; widthCount++)
                    {
                        //if statements to check what character needs to be shown depending on what part of the box
                        if (heightCount == 0 && widthCount == 0)
                        {
                            Console.Write("┌");
                        }
                        else if (heightCount == (h - 1) && widthCount == 0)
                        {
                            Console.Write("└");
                        }
                        else if (heightCount != (h - 1) && heightCount != 0 && widthCount == 0)
                        {
                            Console.Write("│");
                        }
                        else if (widthCount == (w - 1) && heightCount == 0)
                        {
                            Console.WriteLine("┐");
                        }
                        else if (heightCount != (h - 1) && widthCount == (w - 1))
                        {
                            Console.WriteLine("│");
                        }
                        else if (heightCount == (h - 1) && widthCount == (w - 1))
                        {
                            Console.WriteLine("┘");
                        }
                        else if (heightCount == 0 || heightCount == (h - 1))
                        {
                            Console.Write("─");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                //loop to avoid invalid inputs
                bool responseBool = true;
                while (responseBool)
                {
                    //read user input and conditional to restart or exit
                    Console.WriteLine("Would You Like to Draw Another Box (Y/N)");
                    response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        repeat = true;
                        responseBool = false;
                    }
                    else if (response == "N")
                    {
                        repeat = false;
                        responseBool = false;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Only 'Y' or 'N'");
                        responseBool = true;
                    }
                }
            }
        }
    }
}

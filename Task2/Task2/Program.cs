using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO variables begin with lowercase
            double Height1 = 0.0;
            double Height2 = 0.0;
            double Width1 = 0.0;
            double Width2 = 0.0;
            double Area = 0.0; 
            double Area2 = 0.0;



            Console.WriteLine("Please enter Height1 for first reactangle");
            Height1 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Please enter Width1 for first reactangle");
            Width1 = double.Parse(Console.ReadLine());
            
            Area = Height1 * Width1;
            Console.WriteLine("The Area is " + Area);
            Console.ReadLine();
            //While runing the task to continue please Press enter Key to continue the program

            Console.WriteLine("Please enter Height2 for second reactangle");
            Height2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Width2 for Second reactangle");
            Width2 = double.Parse(Console.ReadLine());

            //While runing the task to continue please Press enter Key to continue the program
            Area2 = Height2 * Width2;
            Console.WriteLine("The Area2 is " + Area2);
            Console.ReadLine();

            //While runing the task to continue please Press enter Key to continue the program

            if (Area > Area2)
            {
                Console.WriteLine(Area + "is greater than" + Area2);
            }

            else if (Area == Area2)

            {

                Console.WriteLine(Area + "is equal to" + Area2);

            }
            else

            {
                Console.WriteLine(Area2 + "is greater than" + Area);

            }


            Console.ReadLine();

        }
    }
}

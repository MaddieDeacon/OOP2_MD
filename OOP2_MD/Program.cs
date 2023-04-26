

using OOP2_MD;

namespace MathsProgram
{
    class Program
    {
        static void Main()
        {
            string input1 = string.Empty;
            string input2;
            bool valid = true;
            while (valid == true)
            {
                Console.WriteLine("WELCOME TO THE CARD MATHS TUTOR"); //intoduction for program 
                Console.WriteLine("Please click enter to continue..."); // This is for me to know the user is ready 
                  input1 = Console.ReadLine();
               
                if (input1 == "") //checks if the user clicks enter 
                { valid= false;
                    Testing.test(); //if does runs main program 
                }
                else
                {
                    Console.WriteLine("GOODBYE"); //if not ends program
                    valid = false;
                }

            }

        }
    }
}
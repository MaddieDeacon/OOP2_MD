using MathsProgram;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOP2_MD
{
  
        class Testing 
        {
         
            private static bool deal() // method to see how many cards to deal
            {
            Pack.FisherShuffle(); //cards are automatically shuffled when dealt 
                int input;
                Console.WriteLine("How many cards would you like delt?");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    return false; //if user doesn't enter an integer
                }
                if (input == 1)
                {
                    Card card = Pack.deal(); 
                    Console.WriteLine(Card.card_type(card));
                }
                else
                {
                    if (input < 2 || input > 52) //checks if input is out of range 
                    {
                        return false; 
                    }
                    List<Card> cards = Pack.dealCard(input);
                foreach (Card card in cards)
                    
                {
                    Console.WriteLine(Card.card_type(card));
                    
                    }
                Console.WriteLine(" youre maths question is...."); //starts maths question 
            }
                return true;
            }
            public static void test()
            {
                new Pack();
                bool valid = true;
                bool valid_shuffle;
                bool valid_deal;
                string input;
                while (valid)
                {//starting menu 
                //gives user a opition to have instrcutions, to deal cards, or quit 
                    Console.WriteLine("1. Instructions");
                    Console.WriteLine("2. Deal");
                    Console.WriteLine("3. Quit");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                        //instructions for tutor 
                        Console.WriteLine(" Instructions: ");
                        Console.WriteLine("1. The Program Begins by shuffling cards and selecting two at random");
                        Console.WriteLine("2. These two radnom cards represnt a number. for example 7 of diamonds will be the diigit 7");
                        Console.WriteLine("3. Next, another card is picked from the deck represents a mathematical operation to be used in the problem. Here are the operations that correspond to each suit:" +
                            "\r\nHearts: Addition\r\nDiamonds: Subtraction\r\nClubs: Multiplication\r\nSpades: Division");//using ./r/n for asetheic 
                        Console.WriteLine("4. We will then ask the user, you, to solve the math problem using the two numbers and the operation.");
                        Console.WriteLine("5. Once the user has given their answer, reveal the correct answer by solving the problem yourself.");
                        break;
                        case "2":
                            valid_deal = deal(); //starts deal method 
                        
                            if (valid_deal == false)
                            {
                                Console.WriteLine("Not valid input, please try again"); //asks user to re input if not valid 
                            }
                            break;
                        case "3":
                            Console.WriteLine("Goodbye"); //says goodbye to user when quitting
                            valid = false;
                            break;
                    }
                }
            }
        }
    }
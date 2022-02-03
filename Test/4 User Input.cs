using System;

namespace FirstProgram
{
    class UserInput
    {
        static void Input(string[] args)
        {
            Console.WriteLine("What's your credit card info?");
            int creditcard = Convert.ToInt32(Console.ReadLine());
            /* Function || Stored in variable <--- Converting to int32 <-- Input ||
             * Putting a string from this line will fucky wucky the code owo
             */
            Console.WriteLine(creditcard + " I HAVE YOUR CWEDIT CAWD WINPHO NOW!!!!11!!");



            Console.ReadKey();
        }
    }
}
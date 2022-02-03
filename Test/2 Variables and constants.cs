using System;

namespace FirstProgram
{
    class Variablesandstuff
    {
        static void Variable(string[] args)
        {
            int x = 0, y = 6, z = 3;
            Console.WriteLine(x);
            Console.WriteLine(y);  
            Console.WriteLine(z);


            const string lol = "THOU SHALL NOT CHANGE ME";

            //Commpupation
            x = y + (z * 7);
            Console.WriteLine(x);

            Console.WriteLine(lol);
            Console.WriteLine("Random noombers" + x, y, z);


            Console.ReadKey();
        }
    }
}
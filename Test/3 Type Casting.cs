using System;

namespace FirstProgram
{
    class TypeCasting
    {
        static void Typing(string[] args)
        {
            double a = 3.41;
            int b = Convert.ToInt32(a);

            Console.WriteLine(b);

            int e = 3003;
            string f = Convert.ToString(e);

            Console.WriteLine(f.GetType());

            Console.ReadKey();
        }
    }
}
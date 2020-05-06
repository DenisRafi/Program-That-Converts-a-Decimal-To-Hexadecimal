using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int decn, q, dn = 0, m, l;
            int tmp;
            int s;          
            Console.WriteLine("C# Program That Converts a Decimal To Hexadecimal. -By Denis Rafi");
            Console.WriteLine();
            Console.Write("Enter a Decimal Number: ");
            decn = Convert.ToInt32(Console.ReadLine());
            q = decn;
            for (l = q; l > 0; l = l / 16)
            {
                tmp = l % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                dn = dn * 100 + tmp;
            }
            Console.Write("\nThe Equivalent Hexadecimal Number : ");
            for (m = dn; m > 0; m = m / 100)
            {
                s = m % 100;
                Console.Write("{0}", (char)s);
            }
            Console.ReadKey();
        }          
    }
}

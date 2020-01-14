using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversii
{
    class Program
    {
        static char val(int num)
        {
            if (num >= 0 && num <= 9)
                return (char)(num + 48);
            else
                return (char)(num - 10 + 65);
        }

        static string fromDecimal(int inputNum, int base1)
        {
            string s = "";

            while (inputNum > 0)
            {
                s += val(inputNum % base1);
                inputNum /= base1;
            }

            char[] res = s.ToCharArray();

            Array.Reverse(res);
            return new String(res);
        }

        static void Main()
        {
            int inputNum, base1;

            Console.Write("Input Number = ");
            inputNum = int.Parse(Console.ReadLine());

            Console.Write("Base = ");
            base1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The decimal number " + inputNum + " in base " + base1 + " is " + fromDecimal(inputNum, base1));
            Console.ReadLine();
        }
    }
}

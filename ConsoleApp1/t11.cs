using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace t11
    {
        class Program
        {
            static int mult(int num, int l)
            {
                Console.WriteLine(l + "*" + num + "=" + l * num);
                return l <= 8 ? mult(num, l = l + 1) : 0;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Syötä luku: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int l = 1;
                mult(num, l);
                Console.ReadLine();
            }
        }
    }

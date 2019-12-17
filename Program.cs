using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ConI = 1000;
            const double ConD = 36.6;


            bool boo;
            char ch;
            byte b;
            b = byte.MinValue;
            sbyte sb;
            sb = sbyte.MaxValue;
            short sh;
            ushort ush;
            int i;
            uint ui;
            long l;
            ulong ul;
            decimal de;
            float fl;
            double d0;
  

            boo = true;
            ch = '1';
            b = 100;
            sb = -25;
            sh = short.MaxValue;
            sh = 10000;
            ush = 65535;
            i = 10000000;
            ui = uint.MaxValue;
            l = -1000 * 1000;
            ul = 1000000000;
            de = decimal.MinValue;
            d0 = 127.7;
            fl = -33.1f;

            //ConI = 200;

            var VarOne = 20;
            var VarTwo = 20.5;
            var VarThree = VarOne;

            VarOne = (Int32)VarTwo;
            VarTwo = (Double)VarThree;
            Console.WriteLine(VarOne);
            Console.WriteLine(VarTwo);


            System.Int32 PerOne;
            System.Double PerTwo;
            PerOne = i;
            PerTwo = d0;
            Console.WriteLine("Перая переменная - {0}, Вторая - {1}", PerOne, PerTwo);
            Console.WriteLine("Press any key....");
            //Console.ReadKey();


            i = ++i;
            ch = 'D';
            d0 = d0 +100;
            Console.WriteLine(d0);
            //Console.ReadKey();

            i = 1;
            // ch = i; //can't
            ch = (char)i; // simbol "?"
            // boo = sh; //can't
            // boo = (bool)sh; //can't
            // l = d0; //can't
            l = (long)d0; // lost values after "."
            // ch = fl; //can't
            ch = (char)fl; //simbol "?"
            // d0 = de; //can't
            // d0 = (decimal)de; //can't
            ui = b; //OK
                    // sb = ul; //can't
                    // sb = ul; //can't

            // i = null; //can't

            Nullable<int> Nul = null;
            Console.WriteLine(Nul);
            Console.ReadKey();


            Console.WriteLine(Num);
            Console.ReadKey();





        }
    }
}

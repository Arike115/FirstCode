using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public class Logic : Student
    {
        //arithemetic operators
        // +, -, *, /,%,++,__

        int v = 56;
        int number = 78;

       public int result ()
        {
            int r = v + number;
            Console.WriteLine(r);
            return r;
           
        }

        public int result1()
        {
            int x = number - v;
            Console.WriteLine(x);
            return x;
        }
        public int result2()
        {
            int x = number * v;
            Console.WriteLine(x);
            return x;
        }

        public int result3()
        {
            int x = v/number;
            Console.WriteLine(x);
            return x;
        }

        public int result4( int ft, int dt, int st)
        {
            int f = ft * dt + st;
            Console.WriteLine(f);
            return f;
        }
    }
}

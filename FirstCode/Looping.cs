using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public  class Looping : Logic
    {
        string v = "hello";
        string b = "world";
        string x = "cup";

        int h = 56;
        int o = 45;
        int t = 12;

        

        // conditional statement also known as conditional branching 
       public void checking()
        {
            if(v == b)
            {
                Console.WriteLine("data match");
            }
            else if (x != b)
            {
                Console.WriteLine("data not matched");
            }
            else 
            {
                Console.WriteLine("data does not exist");
            }
        }
        public void check()
        {
            if (h > t && o > t)
            {
                Console.WriteLine("data match");
            }
            else if (h < t || o < t)
            {
                Console.WriteLine("data not matched");
            }
            else
            {
                Console.WriteLine("data does not exist");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1080109_24timeto124
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            while (true)
            {
                string militaryTime = Console.ReadLine();
                militaryTime = c.MilitaryTimeToRegularTime(militaryTime);
                Console.Write(militaryTime);
            }
        }

        
    }
}


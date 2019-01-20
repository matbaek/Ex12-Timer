using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Seconds = 12;
            Console.WriteLine(timer.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClokDelegat
{
    class Program
    {
        static void Main(string[] args)
        {
            Clok clok = new Clok(12,43);
            clok.AlarmClock += c_TimeTowakeUp;
            //clok.Tick();
            clok.TornOf();
        }
        static void c_TimeTowakeUp(object o, MyEventHendler e)
        {
            Console.WriteLine(e.Massege);
            Environment.Exit(0);
        }
    }
}

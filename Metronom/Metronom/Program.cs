using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metronom
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronom m = new Metronom();
            Listener l1 = new Listener();
            l1.Subscribe(m);
            Listener l2 = new Listener();
            l2.Subscribe(m);
            m.Start();
            Console.ReadKey();
        }
    }
}

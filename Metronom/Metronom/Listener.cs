using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metronom
{
    class Listener
    {
        public void Subscribe(Metronom m)
        {
            m.Tick += HeardIt;
        }
        private void HeardIt(Metronom m, TimeofTick t)
        {
            Console.WriteLine("Heard IT ! at {0}",DateTime.Now);
        }
    }
}

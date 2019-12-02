using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metronom
{
    class Metronom
    {
        public event TickHandler Tick;
        public delegate void TickHandler (Metronom m, TimeofTick e);

        public void Start()
        {
            int c = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                if (Tick != null)
                {
                    TimeofTick ToT = new TimeofTick();
                    ToT.TimeOfTick = DateTime.Now;
                    Tick(this, ToT);
                    c += 2;
                }
                if (c == 6)
                {
                    Console.WriteLine("Už pípáš 6 sekund, asi nemáš rád svůj život");
                }

            }
        }
    }
}
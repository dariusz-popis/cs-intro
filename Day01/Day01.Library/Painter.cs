using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Library
{
    //internal delegate uint TimesPaintingCounting(object sender, decimal cost);

    internal class Painter : Worker
    {
        public Painter(string name = "Unnamed Painter") : base(name) { }

        //public TimesPaintingCounting OnPaintStarting;
        public Func<object, decimal, uint> OnPaintStarting;

        public void Paint(string item)
        {
            uint times = 1;
            if (OnPaintStarting != null)
            {
                times = OnPaintStarting.Invoke(this, item.Length);
            }
            for (int i = 0; i < times; i++)
            {
                item.Length.SleepSec();
            }
        }

    }
}

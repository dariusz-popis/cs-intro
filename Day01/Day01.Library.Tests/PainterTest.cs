using Day01.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Day01.Library.Tests
{
    [TestClass]
    public class PainterTests
    {
        [TestMethod]
        public void Paint_Demo()
        {
            Painter painter;

            SetupPainter(out painter);
            AddEventHandler(ref painter);

            painter.Paint("Box");
        }
        private static void SetupPainter(out Painter painter)
        {
            if (DateTime.Now.Second % 2 == 0) painter = new Painter("Pair Painter");
            else painter = null;
        }
        private static void AddEventHandler(ref Painter painter)
        {
            //if(painter==null) painter = new Painter() else p = painter; 
            painter = painter ?? new Painter(); // Demo only

            painter.OnPaintStarting = (s, c) => c > 5 ? 1u : 3u;
        }

        [TestMethod]
        public void InterfaceProp_VsClass()
        {
            Person iP = new Person { Sex = Sex.Male };
            IPeselPersonalData iPPD = iP;
            iPPD.Sex = Sex.Female;

            Console.WriteLine($"iP {iP.Sex}, iPPD {iPPD.Sex}");
        }
    }

    //TODO: Asynchroniczność

    //TODO: Wzorce dev
}

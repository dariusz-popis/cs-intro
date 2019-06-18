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
            var painter = new Painter();

            painter.OnPaintStarting = (s, c) => c > 5 ? 1u : 3u;

            //painter = painter ?? new Painter(); // Demo only
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
    //TODO: Generyki

    //TODO: EntityFramework
    //TODO: Builder

}

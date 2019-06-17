using System;
using Day01.Library.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day01.Library.Tests
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void SwitchKey_MaxSwitchesReached_ThrowsException()
        {
            var tested = new Switch(5);
            tested.SwitchKey(Switch3Keys.Left);
            tested.SwitchKey(Switch3Keys.Middle);
            tested.SwitchKey(Switch3Keys.Left);
            tested.SwitchKey(Switch3Keys.All);
            tested.SwitchKey(Switch3Keys.Left);

            var actual = Assert.ThrowsException<TechnicalException>(() => tested.SwitchKey(Switch3Keys.Off));
            Assert.AreEqual("Maximum switches reached.", actual.Message);
        }
    }
}

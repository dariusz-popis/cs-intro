using Day01.Library.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day01.Library.Tests
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void SwitchKey_MaxSwitchesReached_ThrowsException()
        {
            var tested = new Switch(5);
            tested.SwitchState = Switch3Keys.Left;
            tested.SwitchState = Switch3Keys.Middle;
            tested.SwitchState = Switch3Keys.Left;
            tested.SwitchState = Switch3Keys.All;
            tested.SwitchState = Switch3Keys.Left;

            var actual = Assert.ThrowsException<TechnicalException>(() => tested.SwitchState = Switch3Keys.Off);
            Assert.AreEqual("Maximum switches reached.", actual.Message);
        }

        [TestMethod]
        public void GetSwitchState_ReturnsAppropriateValue()
        {
            var tested = new Switch(5);

            tested.SwitchState = Switch3Keys.Left;

            Assert.AreEqual(Switch3Keys.Left, tested.SwitchState);

            tested.SwitchState = Switch3Keys.All;

            Assert.AreEqual(Switch3Keys.All, tested.SwitchState);
        }

        [TestMethod]
        public void SwichCount_SwitchOperation3Times_ReturnsCorrectSwitchCountNo()
        {
            var tested = new Switch(5)
            {
                SwitchState = Switch3Keys.Left
            };
            var actual = tested.SwitchCount;

            Assert.AreEqual((uint)1, actual);

            tested.SwitchState = Switch3Keys.All;
            actual = tested.SwitchCount;

            Assert.AreEqual(2u, actual);

            tested.SwitchState = Switch3Keys.All;
            actual = tested.SwitchCount;

            Assert.AreEqual(3u, actual);
        }
    }
}

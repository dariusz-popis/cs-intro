using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day01.Library.Tests
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void InternalInstanionatingIsPossible_LibraryWasDecoratedInternalsVisibleToAttribute()
        {
            var worker = new Worker("Ab");
        }

        [TestMethod]
        public void DoWork_SendingSms_Invoked()
        {
            var worker = new Worker("Slavko");

            worker.WorkerMobilePhone += (s, arg) => Console.WriteLine($"--------\nSender is: {s}\nMessage:\n{arg.Message}\n---------");
            //worker.workerMobilePhone.Invoke(worker, "You are one of the top devs");

            //worker.DoWork("A1");
        }

        //private static void CatchSms(object sender, string text)
        //{
        //    Console.WriteLine($"--------\nSender is: {sender}\nMessage:\n{text}\n---------");
        //}
    }
}

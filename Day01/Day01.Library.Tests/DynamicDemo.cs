using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day01.Library.Tests
{
    [TestClass]
    public class DynamicDemo
    {
        [TestMethod]
        public void DynamicInvokeFunctionDemo()
        {
            LogCommonProperty(new { FirstName = "Darko", LastName = "Azure", BirthDate = DateTime.Now.AddYears(-48) });
            var person = new Person { FirstName = "Scarlet", LastName = "Anaconda", BirthDate = new DateTime(1980, 04, 01) };
            LogCommonProperty(person);
        }

        private static void LogCommonProperty(dynamic item)
        {
            Console.WriteLine($"First Name: {item.FirstName}, Last Name: {item.LastName}, Birth Date {item.BirthDate} | {item.GetType().Name}");
        }
    }
}

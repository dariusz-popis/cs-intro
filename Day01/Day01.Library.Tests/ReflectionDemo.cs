using System;
using Day01.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day01.Library.Tests
{
    [TestClass]
    public class ReflectionDemo
    {
        [TestMethod]
        public void InheritanceTestsByIs()
        {
            var tested = new Person();

            LogWithCastingIfIPesel(tested);
        }

        private static void LogWithCastingIfIPesel(object tested)
        {
            if (tested is IPeselPersonalData)
            {
                Console.WriteLine("TRUE");
                var ippd = (IPeselPersonalData)tested;
                ippd.Sex = Sex.Female;
            }
            else
                Console.WriteLine("FALSE");
        }

        [TestMethod]
        public void InheritanceTests()
        {
            if(IsType(typeof(Painter), typeof(Worker)))
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");
        }

        private static bool IsType(Type sourceType, Type compareToType)
        {
            return sourceType == compareToType;
        }

        [TestMethod]
        public void LogAttributes()
        {
            var type = typeof(Person);
            foreach (StickerAttribute item in type.GetCustomAttributes(typeof(StickerAttribute), true))
            {
                Console.WriteLine($"{item}");
            }
        }

        [TestMethod]
        public void GetType_Example()
        {
            var painter = new Painter();

            LogMetadata(painter.GetType());
        }

        [TestMethod]
        public void TypeOf_Example()
        {
            LogMetadata(typeof(Painter));
        }

        private static void LogMetadata(Type type)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(type.FullName);
            Console.WriteLine("---------------------------------");
            foreach (var item in type.GetMembers())
            {
                Console.WriteLine($"{item.Name} : {item.DeclaringType}");
            }
            Console.WriteLine("*\n");
        }
    }
}

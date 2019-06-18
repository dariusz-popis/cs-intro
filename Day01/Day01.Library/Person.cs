using System;
using Day01.Contracts;

namespace Day01.Library
{
    [Sticker(Message = "Nie zapomnij odebrać go z przedszkola.")]
    internal class Person : IPeselPersonalData
    {
        public int Id { get; set; }
        public string NIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        Sex IPeselPersonalData.Sex { get; set; }
        public Sex Sex { get; set; }
    }
}

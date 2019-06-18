using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day01.Contracts;
namespace Day01.Library
{
    internal static class NINValidators
    {
        public static bool IsValidPesel(this IPeselPersonalData pesel)
        {
            return pesel.Sex != Sex.Undefined;
        }
    }
}

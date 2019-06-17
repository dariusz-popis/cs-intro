using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Library
{
    [Flags]
    public enum Switch3Keys
    {
        Off = 0,
        Left = 1,
        Middle = 2,
        Right = 4,
        LeftMiddle = Left | Middle,
        MiddleRight = Middle | Right,
        LeftMiddleRigt = Left | Middle | Right,
        All = LeftMiddleRigt, 
    }
}

using System;

namespace Day01.Library
{
    [AttributeUsage(AttributeTargets.Constructor|AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    sealed class StickerAttribute : Attribute
    {
        public string Message;
        public override string ToString()
        {
            return $"Sticker has Message:\n{Message}";
        }
    }
}

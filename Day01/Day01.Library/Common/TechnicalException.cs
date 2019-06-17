using System;

namespace Day01.Library.Common
{
    [Serializable]
    public class TechnicalException : Exception
    {
        public TechnicalException() { }
        public TechnicalException(string message) : base(message) { }
        public TechnicalException(string message, Exception inner) : base(message, inner) { }
        protected TechnicalException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

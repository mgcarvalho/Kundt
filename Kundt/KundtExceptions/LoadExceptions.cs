namespace KundtExceptions
{
    using System;

    [System.Serializable]
    public class LoadExceptions : Exception
    {
        public LoadExceptions() { }
        public LoadExceptions(string message) : base(message) { }
        public LoadExceptions(string message, Exception inner) : base(message, inner) { }
        protected LoadExceptions(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}

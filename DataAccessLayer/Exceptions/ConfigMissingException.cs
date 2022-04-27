using System;
using System.Runtime.Serialization;

namespace DataAccessLayer.Exceptions
{
    [Serializable]
    public class ConfigMissingException : Exception
    {
        public ConfigMissingException() : base("Config missing, please go to settings and setup config.")
        {
        }

        public ConfigMissingException(string message) : base(message)
        {
        }

        public ConfigMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConfigMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
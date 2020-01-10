using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex4
{
    public class TemperatureException : ApplicationException
    {
        public TemperatureException() { }
        public TemperatureException(string message) : base(message) { }
        public TemperatureException(string message,
        System.Exception inner)
        : base(message, inner) { }
        protected TemperatureException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
      
    }

}

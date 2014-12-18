using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionTypes
{
    public class UIException : BaseException, ISerializable
    {
        public UIException() : base()
        {
            //todo: implement
        }

        public UIException(string message) 
            : base(message)
        {
            //todo: impelment
        }

        public UIException(string message, System.Exception inner) 
            : base(message, inner)
        {
            //todo: implement
        }

        public UIException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            //todo: implement
        }
    }
}

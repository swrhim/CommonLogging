using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionTypes
{
    public class BaseException : System.Exception, ISerializable
    {
        public BaseException() : base()
        {
            //todo: implement
        }

        public BaseException(string message) 
            : base(message)
        {
            //todo: impelment
        }

        public BaseException(string message, System.Exception inner) 
            : base(message, inner)
        {
            //todo: implement
        }

        public BaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            //todo: implement
        }
    }
}

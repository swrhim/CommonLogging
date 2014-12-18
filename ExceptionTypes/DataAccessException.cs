using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionTypes
{
    public class DataAccessException : BaseException, ISerializable
    {
        public DataAccessException() : base()
        {
            //todo: implement
        }

        public DataAccessException(string message) 
            : base(message)
        {
            //todo: impelment
        }

        public DataAccessException(string message, System.Exception inner) 
            : base(message, inner)
        {
            //todo: implement
        }

        public DataAccessException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            //todo: implement
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionHandlers
{
    public class BusinessLayerException : BaseException, ISerializable
    {
        public BusinessLayerException() : base()
        {
            //todo: implement
        }

        public BusinessLayerException(string message) 
            : base(message)
        {
            //todo: impelment
        }

        public BusinessLayerException(string message, System.Exception inner) 
            : base(message, inner)
        {
            //todo: implement
        }

        public BusinessLayerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            //todo: implement
        }
    }
}

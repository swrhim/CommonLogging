using CommonLogging.ExceptionTypes;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionHandlers
{
    public static class UILayerExceptionHandler
    {
        public static bool HandleException(ref System.Exception ex)
        {
            bool rethrow = false;
            if(ex is BaseException)
            {
                //do nothing
            }
            else
            {
                rethrow = ExceptionPolicy.HandleException(ex, "UIException");
            }

            return rethow;
        }
    }
}

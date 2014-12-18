using CommonLogging.ExceptionTypes;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionHandlers
{
    public static class BusinessLayerExceptionHandler
    {
        public static bool HandleException(ref System.Exception ex)
        {
            bool rethrow = false;
            if((ex is DataAccessException))
            {
                rethrow = ExceptionPolicy.HandleException(ex, "DataAccessException");
                ex = new DataAccessException(ex.Message);
            }
            else
            {
                rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogicException");
            }

            if (rethrow)
                throw ex;

            return rethrow;
        }
    }
}

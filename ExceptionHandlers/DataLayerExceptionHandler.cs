using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLogging.ExceptionHandlers
{
    public static class DataLayerExceptionHandler
    {
        public static bool HandleException(ref System.Exception ex)
        {
            bool rethrow = false;
            rethrow = ExceptionPolicy.HandleException(ex, "DataAccessException");
            if (rethrow) throw ex;
            return rethrow;
        }
    }
}

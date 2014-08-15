using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service
{
    public class ServiceBase
    {
        protected TResult LogIfOperationFailed<TResult>(Func<TResult> action, string errorMessage, params object[] values)
        {
            try
            {
                return action();
            }
            catch (Exception ex)
            {
                var msg = String.Format(errorMessage, values);
                msg += String.Format("Error Details: ", GetCompleteExceptionMessage(ex));

                //Logger.Write(msg);
                throw ex;
            }
        }

        protected void LogIfOperationFailed(System.Action action, string errorMessage, params object[] values)
        {
            LogIfOperationFailed(() =>
            {
                action();
                return (object)null;
            }, errorMessage, values: values);
        }

        string GetCompleteExceptionMessage(Exception exception)
        {
            var ex = exception;
            var msg = String.Empty;
            while (ex != null)
            {
                msg += String.Format("{0}\n", ex.Message);
                ex = ex.InnerException;
            }

            return msg;
        }
    }
}

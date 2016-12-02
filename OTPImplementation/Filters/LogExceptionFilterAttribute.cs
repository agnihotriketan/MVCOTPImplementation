using System.Web.Http.Filters;

namespace Dpts.Web.Filters
{
    public sealed class LogExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
           /* var exceptionHandler = ServiceLocator.Current.GetInstance<ILogManager>();
            exceptionHandler.LogException(new ExceptionModel
            {
                Exception = actionExecutedContext.Exception,
                ApplicationName = Constants.ApplicationName
            });*/
        }
    }
}
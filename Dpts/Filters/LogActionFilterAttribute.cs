using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dpts.Web.Filters
{
    public sealed class LogActionFilterAttribute : ActionFilterAttribute
    {
        private Stopwatch _stopwatch;

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            _stopwatch = new Stopwatch();
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            object request = null, response = null;


            AddLogs(actionExecutedContext, request, response, null, _stopwatch.Elapsed.TotalSeconds);
        }

        private static object Clone(object req)
        {
            var deserializeSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.DeserializeObject<object>(JsonConvert.SerializeObject(req),
                deserializeSettings);
        }

        private static void AddLogs(HttpActionExecutedContext actionContext, object request, object response,
            object status, double responseTime)
        {
            /*var logger = ServiceLocator.Current.GetInstance<ILogManager>(); 
            logger.InsertLog(new LogModel
            {
                Title = "",
                CallType = GetCallType(actionContext),
                Request = request,
                Response = response,
                ResponseTime = responseTime,
            });*/
        }
    }
}
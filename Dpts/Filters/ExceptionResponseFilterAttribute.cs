using System.Net.Http;
using System.Web.Http.Filters;

namespace Dpts.Web.Filters
{
    public sealed class ExceptionResponseFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //var baseApplicationException = ExceptionUtility.GetBaseApplicationException(actionExecutedContext.Exception);
            //actionExecutedContext.Response = baseApplicationException != null
            //    ? GetBaseApplicationExceptionResponse(baseApplicationException)
            //    : GetInternalServerErrorResponse();
        }

        private static HttpResponseMessage GetBaseApplicationExceptionResponse()
        {
            //return new HttpResponseMessage(baseApplicationException.HttpStatusCode)
            //{
            //    Content =
            //        new StringContent(JsonConvert.SerializeObject(baseApplicationException.GetErrorInfo(),
            //            new ErrorInfoTranslator(), new InfoTranslator()))
            //};
            return new HttpResponseMessage();
        }

        private static HttpResponseMessage GetInternalServerErrorResponse()
        {
            //return new HttpResponseMessage(HttpStatusCode.InternalServerError)
            //{
            //    Content =
            //        new StringContent(
            //            JsonConvert.SerializeObject(new ErrorInfo(FaultCodes.Application, ErrorMessages.Application()),
            //                new ErrorInfoTranslator(), new InfoTranslator()))
            //};
            return new HttpResponseMessage();
        }
    }
}
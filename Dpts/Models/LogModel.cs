namespace Dpts.Web.Models
{
    public class LogModel
    {
        public LogModel(string applicationName)
        {
            ApplicationName = applicationName;
        }

        public LogModel()
        {
        }

        public string CallType { get; set; }
        public int ProviderId { get; set; }
        public object Request { get; set; }
        public object Response { get; set; }
        public double ResponseTime { get; set; }
        public string Title { get; set; }
        public string ApplicationName { get; set; }
        public string SessionId { get; set; }
    }
}
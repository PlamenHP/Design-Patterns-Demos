
namespace Singleton
{
    using System;

    public class LogEvent
    {
        public string Message { get; private set; }

        public DateTime EventDate { get; private set; }

        public LogEvent(string message)
        {
            this.Message = message;
            this.EventDate = DateTime.Now;
        }
    }
}
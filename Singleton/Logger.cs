
namespace Singleton
{
    using System;
    using System.Collections.Generic;

    public class Logger
    {

        private List<LogEvent> Events;
        private static Logger instance;
        private static object synclock = new object();
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synclock)
                    {
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }

        private Logger()
        {
            this.Events = new List<LogEvent>();
        }

        public void SaveToLog(string message)
        {
            Events.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            foreach (var ev in Events)
            {
                Console.WriteLine($"Time {ev.EventDate.ToShortDateString()}, Event: {ev.Message}");
            }
        }
    }
}
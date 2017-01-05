
namespace Singleton
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static void Main()
        {
            var log = Logger.Instance;

            log.SaveToLog("message 1");
            log.SaveToLog("message 2");

            var log2 = Logger.Instance;

            log2.SaveToLog("message from log 2");

            log.PrintLog();
        }
    }
}
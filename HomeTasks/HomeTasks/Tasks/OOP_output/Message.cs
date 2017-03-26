using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public static class Message
    {
        public static void LogHappyMessage(ILogger logger)
        {
            logger.Log("I am happy!");
        }
    }
}

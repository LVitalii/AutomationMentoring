using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public class AggregateLogger : ILogger
    {
        public AggregateLogger()
        {
            collection = new List<ILogger>();
            collection.Add(new ConsoleLogger());
            collection.Add(new FileLogger());
        }

        public List<ILogger> collection;
        
        public void Log(string text)
        {
            foreach(ILogger action in collection)
            {
                action.Log(text);
            }
        }

        
    }
}

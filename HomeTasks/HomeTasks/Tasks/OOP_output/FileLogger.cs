using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeTasks
{
    public class FileLogger : ILogger
    {
        public void Log(string text)
        {
            string path = "d:\\Projects\\FileLogger.txt";
            try
            {                
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.AppendAllText(path, text);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have accesse to " + path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Path is not found: " + path+ "\nCheck the path is valid");
            }
        }
    }
}

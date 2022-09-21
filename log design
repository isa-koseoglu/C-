using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inherit_Recapt
{
    class CostummerManager:LoggerManager
    {
        
        public ILogger[] logger { get; set; }
        public void Add()
        {
            LoggerRun(logger, "Adding Process Begins");
            Console.WriteLine("Costume Add");
            LoggerRun(logger, "Adding Completed");
        }
        public void Update()
        {
            LoggerRun(logger, "Updating Process Begins");
            Console.WriteLine("Costume Update");
            LoggerRun(logger, "Updating Completed");
        }
    }
    class LoggerManager
    {
        public void LoggerRun(ILogger[] logger, string message)
        {
            foreach (var item in logger)
            {
                item.Log(message);
            }
        }
    }
    interface ILogger
    {
        void Log(string message);
    }
    class DatabaseLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DatabaseLog -{0}", message);
        }
    }
    class FileLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("FileLog -{0}", message);
        }
    }
    class JsonLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Json -{0}",message);
        }
    }
}

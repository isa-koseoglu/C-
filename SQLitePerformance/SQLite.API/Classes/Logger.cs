using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace SQLite.API.Classes
{
    public static class Logger
    {
       public static void LogWriter(string function ,string value,byte finish)
        {
            string filename = "LOG.txt";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(directoryPath, filename);
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            StreamWriter writer = File.AppendText(filePath);
            string desingWriter = "[ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:fff") + " ] >>> " + function;
            writer.WriteLine(desingWriter);
            writer.WriteLine("Out = " + value);
            if (finish > 0)
            {
                writer.WriteLine("------------------------------------------");
            }
            writer.Close();
        }
    }
}

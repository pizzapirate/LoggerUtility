using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextToTxtFile
{
    public static class Logger
    {
        private readonly static StringBuilder LogString = new();
        // Both WriteLine and Write allow concatenation 
        public static void WriteLine(string str)
        {
            Console.WriteLine(str);
            LogString.Append(str).Append(Environment.NewLine);
        }
        public static void Write(string str)
        {
            Console.Write(str);
            LogString.Append(str);

        }
        public static void SaveLog()
        {
            string path = "C:\\Users\\MilesVellozzo\\Documents\\Dump For Console to Txt\\Output.txt";
            using StreamWriter sw = File.AppendText(path);
            sw.Write(LogString.ToString());
            sw.Close();
            sw.Dispose();

        }
    }
}

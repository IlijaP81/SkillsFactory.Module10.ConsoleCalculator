using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    
    public interface ILogger 
    { 
        void Event(string message);
        void Error(string message);
    }
    internal class Logger : ILogger
    {
        /// <summary>
        /// Provides error's message to console
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Provides event's message to console
        /// </summary>
        /// <param name="message"></param>
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}

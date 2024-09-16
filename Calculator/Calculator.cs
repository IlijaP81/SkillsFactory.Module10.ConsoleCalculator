using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal interface ICalculator
    {
        void Calculate(double x, double y);
    }
    internal class Calculator : ICalculator
    {
        ILogger logger { get; }
        public Calculator(ILogger logger) 
        { 
            this.logger = logger;
        }

        
        /// <summary>
        /// Summarize two digits
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Calculate(double x, double y)
        {
            logger.Event($"Калькулятор завершил сложение {x} и {y} с результатом {x + y}");
        }
    }
}

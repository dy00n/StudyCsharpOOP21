using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재날씨 {message}");
            //Console.WriteLine($"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재날씨 {weather}");
        }
    }
}

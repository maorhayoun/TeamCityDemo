using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamCityDemo
{
    public class MyLogic
    {
        public bool PrintNTimes(string input, int n)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");

            if (n < 0)
             //   throw new InvalidOperationException("n should be greater than zero");
             return false;

            Thread.Sleep(1000);

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(input);
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;

namespace brackets_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            var valid = new Validator();

            var cases = new List<string>
            {
                string.Empty,
                "{()}",
                "{([])}",
                "[{()}]([[{()}]])",

                "{()}(",
                "[{()}",
                "{()}]"
            };

            foreach(var item in cases)
            {
                Console.WriteLine($"value: {item}, result: {valid.IsBalanceBrackets(item)}");
            }

            Console.ReadKey();
        }
    }
}

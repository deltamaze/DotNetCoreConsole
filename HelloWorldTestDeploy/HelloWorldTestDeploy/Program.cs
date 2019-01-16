using System;
using NLog;

namespace HelloWorldTestDeploy
{
    class Program
    {
        static void Main(string[] args)
        {
            //purpose push to terminal ubuntu server, test input, output, log writing
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Key value to test read key.");
            string input = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine(String.Format("\ninput value: {0}",input));

            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Trace("TraceTest");
            logger.Info("InfoTest");
            logger.Error("ErrorTest");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

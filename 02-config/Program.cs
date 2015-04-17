using System;
using Microsoft.Framework.ConfigurationModel;

namespace Config02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new Configuration()
                .AddCommandLine(args);

            Console.WriteLine("Hello, {0}", config.Get("msg"));
            Console.ReadLine();
        }
    }
}
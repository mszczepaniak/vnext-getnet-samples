using System;

using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.ConfigurationModel.Json;

namespace Config03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new Configuration(".")
                .AddJsonFile("configs\\config.json")
                .AddCommandLine(args);

            Console.WriteLine("Hello, {0}", config.Get("msg"));
            Console.ReadLine();
        }
    }
}
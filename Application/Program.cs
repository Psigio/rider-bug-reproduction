using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Serilog.Log.Logger.Information("Hello World from Logger!");
        }
    }
}

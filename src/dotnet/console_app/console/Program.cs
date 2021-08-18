using System;
using System.Threading.Tasks;
using lib;

namespace console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string name = "World";
            if (args.Length > 0)
                name = args[0];
            await Console.Out.WriteLineAsync($"Hello {name}! Time={Util.GetTimeString()}");
        }
    }
}

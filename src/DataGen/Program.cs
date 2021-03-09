using System;

namespace DataGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            var lnCount = 10;

            if (args.Length > 1) int.TryParse(args[0], out lnCount);

            for (int ln = 0; ln < lnCount; ln++ )
            {
                Console.WriteLine(generator.GetRandomLine());
            }


        }
    }
}

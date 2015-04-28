using System;
using System.IO;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static int Main(string[] args)
        {
            // Check the argument and file exists
            if (args.Length == 0 || !File.Exists(args[0]))
            {
                Console.Write("You failed to specify the file to read, or entered a non existant file path.\nPlease try again with the file name as the first argument.");
                return 0;
            }

            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line) continue;

                    if ("" == line) continue;

                    PrintHexToDecimal(line);
                }
            }

            return 0;
        }

        static void PrintHexToDecimal(string hexString)
        {
            int convertedDecimal = Convert.ToInt32(hexString, 16);
            Console.WriteLine(convertedDecimal);
        }
    }
}

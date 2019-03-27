using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using Utility;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter argument.");
                Console.ReadLine();
                return;                   
            }
            if (args.Length >2)
            {
                System.Console.WriteLine("Please enter a valid argument.");
                Console.ReadLine();
                return;
            }

            string strArg1 = args[0];
            string strArg2 = args[1];

            if(!Utility.Utility.IsValidPath(strArg2))
            {
                System.Console.WriteLine("Please enter a valid file Path.");
                Console.ReadLine();
                return;
            }
            FileDetails fd = new FileDetails();

            switch(strArg1.ToUpper())
            {
                case "-V": System.Console.WriteLine(fd.Version(strArg2)); break;
                case "--V": System.Console.WriteLine(fd.Version(strArg2)); break;
                case "/V": System.Console.WriteLine(fd.Version(strArg2)); break;
                case "-S": System.Console.WriteLine(fd.Size(strArg2)); break;
                case "--S": System.Console.WriteLine(fd.Size(strArg2)); break;
                case "/S": System.Console.WriteLine(fd.Size(strArg2)); break;
                default:Console.WriteLine("Invalid selection.");break;
            }

            Console.ReadLine();
        }
    }
}

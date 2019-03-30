using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0732116_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Downloading a file");
            Download();
            Console.ReadLine();


        }

        public static void Download ()
        {
            Thread.Sleep(3000);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soap_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndTestPrimeNumber.CreateAndTestPrimeNumberClient catpnc = new CreateAndTestPrimeNumber.CreateAndTestPrimeNumberClient();

            int i = 0;
            while((i++) < 100)
            Console.WriteLine(catpnc.CreateAndTest());
            Console.ReadLine();
        }
    }
}

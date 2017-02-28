using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service_CreateNumberAndTestPrimality
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CreateAndTestPrimeNumber : ICreateAndTestPrimeNumber
    {
        PrimeNumberGenerator.PrimeNumberGeneratorClient pngc = new PrimeNumberGenerator.PrimeNumberGeneratorClient();
        PrimeNumberTester.TestPrimeNumberClient tpc = new PrimeNumberTester.TestPrimeNumberClient();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string CreateAndTest()
        {
            var number = pngc.GetRandomPrimeNumber();
            bool decision = tpc.TestIfIsPrimeNumber(number);

            if (decision == true)
            {
                return "Prime number !";
            }
            else
            {
                return "Is not a prime number !";
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

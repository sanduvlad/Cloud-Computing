using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapService_VerifyPrimeNumber
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class VerifyPrimeNumberService : IVerifyPrimeNumberService
    {
        public string DecideIfPrime(int value)
        {
            if (Isprime(value))
            {
                return "Is prime !";
            }

            return "Is not prime !";
        }

        private bool Isprime(int nr)
        {
            for (int i = 2; i < Math.Sqrt(nr); i++)
            {
                if (nr % i == 0)
                {
                    return false;
                }
            }
            return true;
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

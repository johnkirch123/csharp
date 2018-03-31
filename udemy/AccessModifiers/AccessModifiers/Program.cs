using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        public class GoldCustomer : Customer
        {
            public void OfferVoucher()
            {
                //this. - checking to see available methods
            }
        }

        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}

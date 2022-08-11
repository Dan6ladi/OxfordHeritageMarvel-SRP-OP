using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxfordHeritageMarvel
{
    public abstract class Payment 
    {
        public double AgencyFee = 0.1d;
        public double interest = 0.22d;
        public double deposit { get; set; }

        public abstract double CalcReturns();
    }
    public class Returns
    {
        public double TotalClientPay(List<Payment> investments) 
        {

            double totalReturns = 0;

            try
            {
                foreach (var payment in investments)
                {
                    totalReturns = payment.CalcReturns();

                }
                Console.WriteLine(totalReturns);
            }
            catch (Exception message)
            {

                throw message;
            }
            return totalReturns;
            
        }

    }
    public class Agrolyfe : Payment
    {
        public double deposit { get; set; }
        public double interest { get; set; }
        public double AgencyFee = 0.1d;

        public override double CalcReturns()
        {
            return deposit * interest * AgencyFee;
        }
    }
    public class Buy2Sell : Payment
    {
        public double deposit { get; set; }
        public double interest { get; set; }
        public double AgencyFee = 0.1d;

        public override double CalcReturns()
        {
            return deposit * interest * AgencyFee;
        }
    }
}

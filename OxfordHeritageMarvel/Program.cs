namespace OxfordHeritageMarvel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var payment = new List<Payment>();
            payment.Add(new Agrolyfe() { interest = 0.22d, AgencyFee = 0.1d });
            payment.Add(new Buy2Sell() { interest = 0.22d, AgencyFee = 0.1d });

            Returns returns = new Returns();
            returns.TotalClientPay(payment);
            
         

          


            Console.WriteLine("Welcome to OxfordHeritageMarvel.\n please enter your firstname and last name: ");
            string name = Console.ReadLine();

            Console.WriteLine("please enter amount you want to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter duration");
            int duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Your Returns for the duration is: " + (returns.TotalClientPay(payment)* amount));
        }
    }
}
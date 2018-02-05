using System;

namespace DotNet____Vivian
{
    class Program
    {
        public string name ;
        public  string address; 
        public int phonenumber;
        public string ptype;
        public double rfinalcost;

        static void Main(string[] args)
        {
            Gold Gnewmember;
            Gnewmember = new Gold();

            Regular Rnewmember;
            Rnewmember = new Regular();

            int choice =0 ;

            DisplayMenu();
            choice =  Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Guest();
            }
            if (choice == 2)
            {
                Console.WriteLine("2");
            }
            if (choice != 1 || choice != 2)
            {
                Console.WriteLine("The variable is set to false.");
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to ComCol's Express Delivery Company\n");
            Console.WriteLine("1.Regular/Guest Membership");
            Console.WriteLine("2.Gold Membership");
            Console.WriteLine("3.Exit\n");
            Console.WriteLine();
            Console.WriteLine("Enter your choice:");
        }

         static void Guest()
        {
            Regular Rnewmember;
            Rnewmember = new Regular();

            Console.Clear();
            // Input from user about name
            Console.WriteLine("Enter your name:");
            Rnewmember.name = Convert.ToString(Console.ReadLine());
            // Input from user about address
            Console.WriteLine("Enter your address:");
            Rnewmember.address = Convert.ToString(Console.ReadLine());
            // Input from user about telephone
            Console.WriteLine("Enter your telephone number:");
            Rnewmember.telephone = Convert.ToInt32(Console.ReadLine());
            // Input from user about Payment 
            Console.WriteLine("Enter your Payment method:");
            Rnewmember.PaymentM = Convert.ToString(Console.ReadLine());
            Package();

            Console.WriteLine("Name: {0}");
            Console.WriteLine("Address: {0}");
            Console.WriteLine("Telephone: {0}");
            Console.WriteLine("Payment Method: {0}");
            Console.WriteLine("Shipment Cost: {0}");

        }

        static void Package () // Package Function 
        {
            Package NewPackage;
            NewPackage = new Package();

            double standardcost = 1000;
            double standardcostextra = 80;

            double overnightcost = 1500;
            double overnightcostextra = 100;

            double samedaycost = 2500;
            double samedaycostextra = 120;

            int servicetype = 0;


            double overweight = 0;
            double weight = 0;
            double minusweight = 0;
            double standardweight = 10;
            double shippingcost = 0;
            double cost = 0;
            double cost1 = 0; 
            double finalcost = 0;

            Console.WriteLine("Discrption of package:");
            NewPackage.Pcontent = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Package weight:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Service Type:");
            Console.WriteLine("1 >>> Standard 3 - 5 Business days || Per Lbs between 0 -10 {0} || Every extra Lbs ", standardcost);
            Console.WriteLine("2 >>> Overnight 12 - 24 hours || Per Lbs between 0 -10 || Every extra Lbs ");
            Console.WriteLine("3 >>> Same-Day 6 - 12 hours || Per Lbs between 0 -10 || Every extra Lbs ");

            servicetype = Convert.ToInt32(Console.ReadLine());
    

            if ( servicetype == 1)
            {
                if (weight > 10 )
                {
                    minusweight = weight - standardweight;
                    cost = minusweight*standardcostextra;
                    cost1 = standardcost*standardweight;

                    finalcost = cost1+cost;
                    Console.ReadKey();
                    RegularReceipt();

                }
                else 
                {

                 finalcost = weight*standardcost;
                 Console.ReadKey();

                }

            }
            if ( servicetype == 2)
            {
                if (weight > 10 )
                {
                    minusweight = weight - standardweight;
                    cost = minusweight*overnightcostextra;
                    cost1 = overnightcost*standardweight;

                    finalcost = cost1+cost;
                    Console.ReadKey();

                }
                else 
                {
                    
                 finalcost = weight*overnightcost;
                 Console.ReadKey();

                }
            }

            if ( servicetype == 3)
            {
                if (weight > 10 )
                {
                    minusweight = weight - standardweight;
                    cost = minusweight*samedaycostextra;
                    cost1 = samedaycost*standardweight;

                    finalcost = cost1+cost;
                    Console.ReadKey();

                }
                else 
                {
                    
                 finalcost = weight*samedaycost;
                 Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("Pleaase Enter one of these choise 1,2 or 3 ");
                Console.ReadKey();
            }

            
        }

            static void PackageCost()

            {

            }

            static void RegularReceipt()
            {
                Console.WriteLine("Name: {0}");
                Console.WriteLine("Address: {0}");
                Console.WriteLine("Telephone: {0}");
                Console.WriteLine("Payment Method: {0}");
                Console.WriteLine("Shipment Cost: {0}");


            }

    }
}

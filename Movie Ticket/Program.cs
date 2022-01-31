using System;

namespace Movie_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName;
            double adultTicketPrice;
            double childTicketPrice;
            int noOfadultTicketSold;
            int noOfchildTicketSold;
            double percentDonation;
            double grossAmount;
            double amountDonated;
            double netSaleAmount;
            Console.WriteLine("Enter the movie name:");
            movieName = Console.ReadLine();
            Console.WriteLine("Enter the price of an adult ticket:");
            adultTicketPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price of a child ticket");
            childTicketPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of adult ticket sold: ");
            noOfadultTicketSold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of child ticket sold: ");
            noOfchildTicketSold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of percentage donation: ");
            percentDonation = Convert.ToDouble(Console.ReadLine());
            grossAmount = adultTicketPrice * noOfadultTicketSold + childTicketPrice * noOfchildTicketSold;
            amountDonated = grossAmount * percentDonation;
            netSaleAmount = grossAmount - amountDonated;
            Console.WriteLine("Movie Name: " + movieName);
            Console.WriteLine("Number of ticket sold: " + (noOfadultTicketSold + noOfchildTicketSold));
            Console.WriteLine("GrossAmount: " + grossAmount);
            Console.WriteLine("Percentage of gross amount donated: " + percentDonation);
            Console.WriteLine("Amount Donated: " + amountDonated);
            Console.WriteLine("Net Sale: " + netSaleAmount);
        }
    }
}

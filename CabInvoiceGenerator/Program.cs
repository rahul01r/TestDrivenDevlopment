namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC1
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator();
            double fare = cabInvoiceGenerator.CalculatFare(10, 5);
            Console.WriteLine("Cab Fare=" + fare);


            //UC2
            Ride[] ride = { new Ride(1, 2), new Ride(3, 4) };
            double getMultiple = cabInvoiceGenerator.GetMultipleRideFare(ride);
            Console.WriteLine("Array :" + getMultiple);
            //UC3
            InvoiceSummary data = cabInvoiceGenerator.GetAverageFare(ride);
            Console.WriteLine("\nThe Average Fare : " + data.averageFare + "\nThe Total Number Of Rides: " + data.noOfRides);
          
        }
    }
}
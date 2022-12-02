namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Cab Service");
            //UC1
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator();
            double fare = cabInvoiceGenerator.CalculatFare(10, 5);
            Console.WriteLine("Cab Fare=" + fare);

        }
    }
}
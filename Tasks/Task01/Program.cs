namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double priceSmallRoom = 25;
            const double priceLargeRoom = 35;
            double taxRate = 6;
            Console.Write("Enter Number Of Small Room: ");
            string numberSmallRoom = Console.ReadLine();
            Console.Write("Enter Number Of Large Room: ");
            string numberLargeRoom = Console.ReadLine();
            double cost = (priceSmallRoom * double.Parse(numberSmallRoom)) + (priceLargeRoom * double.Parse(numberLargeRoom));
            double tax = (cost / 100) * taxRate;
            double totalEstimate = cost + tax;
            Console.WriteLine($"Number Of Small Room: {numberSmallRoom}");
            Console.WriteLine($"Number Of Large Room: {numberLargeRoom}");
            Console.WriteLine($"Price Per Small Room: ${priceSmallRoom}");
            Console.WriteLine($"Price Per Lagre Room: ${priceLargeRoom}");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax.ToString("F2")}");
            Console.WriteLine($"Total Estimate: ${totalEstimate.ToString("F2")}");
            Console.Write($"This Estimate Is Valid For 30 Days");
        }
    }
}

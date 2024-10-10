namespace Homework1ConsoleApp
{
    enum TransactionType
    {
        Buy,
        Sell
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var nominal = 0;
            var TradePrice = 0.0;
            var originalPrice = 0.0;
            var currentValue = 0.0;

            Console.WriteLine("Input the nominal of the trade:");
            var userInputNominal = Console.ReadLine();
            nominal = Int32.Parse(userInputNominal);

            Console.WriteLine("Input the Trade price of the trade:");
            var userInputPrice = Console.ReadLine();
            TradePrice = double.Parse(userInputPrice);

            Console.WriteLine("Input the Trade type of the trade:");
            TransactionType trcType;
            var userInputTransType = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInputTransType, true);

            currentValue = trcType == TransactionType.Buy ? (1 * nominal * TradePrice) : (-1 * nominal * TradePrice);
            Console.WriteLine($"Current Value for the {trcType} transaction : {currentValue}");

            if (trcType == TransactionType.Sell)
            {
                var profitlossValue = 0.0;
                Console.WriteLine("Input the Origial price of the trade:");
                string userInputOrigPrice = Console.ReadLine();
                originalPrice = double.Parse(userInputOrigPrice);
                profitlossValue = (TradePrice - originalPrice) * nominal;
                Console.WriteLine($"Profit Loss Value for the {trcType} transaction : {profitlossValue}");
            }
            
            Console.ReadLine();
        }
    }
}

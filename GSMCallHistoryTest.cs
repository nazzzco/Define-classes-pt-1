namespace HomeworkDefineClass1
{
    using System;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        private const decimal pricePerMinute = 0.37m;

        public static void TestCallHistory()
        {
            var gsm = new GSM("3310", "Nokia");
            gsm.AddCall(new Call(new DateTime(2016, 05, 16, new Random(Guid.NewGuid().GetHashCode()).Next(23), new Random(Guid.NewGuid().GetHashCode()).Next(59), 0), "0884123321", TimeSpan.FromSeconds(125)));
            gsm.AddCall(new Call(new DateTime(2015, 03, 13, new Random(Guid.NewGuid().GetHashCode()).Next(23), new Random(Guid.NewGuid().GetHashCode()).Next(59), 0), "0878231512", TimeSpan.FromSeconds(210)));
            gsm.AddCall(new Call(new DateTime(2014, 08, 30, new Random(Guid.NewGuid().GetHashCode()).Next(23), new Random(Guid.NewGuid().GetHashCode()).Next(59), 0), "0894312513", TimeSpan.FromSeconds(333)));
            gsm.PrintCallHistory();
            var totalPrice = gsm.CalculateTotalPrice(pricePerMinute);
            Console.WriteLine($"Total price of all calls: {totalPrice:0.00} lv.\n");
            gsm.DeleteCall(gsm.CallHistory.OrderByDescending(x => x.Duration).FirstOrDefault()); //remove longest call
            var newTotalPrice = gsm.CalculateTotalPrice(pricePerMinute); // re-calculate total price
            Console.WriteLine($"Total price without longest call: {newTotalPrice:0.00} lv.\n"); //print new total price
            gsm.ClearCallHistory(); //finally clear the call history
            gsm.PrintCallHistory(); //...and print it
        }
    }
}

namespace HomeworkDefineClass1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMTest
    {
        private const int arrayLength = 3;
        private static string[] models = { "Z3 Compact", "P9", "Priv" };
        private static string[] manufacturers = { "Sony", "Huwawei", "Blackberry" };
        private static decimal[] prices = { 880m, 990m, 750m };
        private static string[] owners = { "Nasko", "Pesho", "Mitko" };
        private static Battery[] batteries = { new Battery(hoursTalk: 22, hoursIdle: 108, type: BatteryType.NiMH),
                                               new Battery(hoursTalk: 32, hoursIdle: 186, type: BatteryType.LiIon),
                                               new Battery(type: BatteryType.NiCd) };
        private static Display[] displays = { new Display(numberOfColors: 16000000, size: 4.0),
                                              new Display(numberOfColors: 16000000, size: 5.2),
                                              new Display(numberOfColors: 16000000, size: 5.5) };
        public static void TestGSM()
        {
            GSM[] arrayOfGSMs = new GSM[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfGSMs[i] = new GSM(models[i], manufacturers[i], prices[i], owners[i], batteries[i], displays[i]);
            }

            foreach (var gsm in arrayOfGSMs)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}

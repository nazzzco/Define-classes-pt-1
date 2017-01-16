namespace HomeworkDefineClass1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;
        private List<Call> callHistory = new List<Call>();
        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 190m, "Chocho", new Battery(type: BatteryType.NiCd, hoursTalk: 15, hoursIdle: 100), new Display(16000000, 3.5));

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
        }

        public string Model { get { return model; } set { model = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public Battery Battery { get { return battery; } set { battery = value; } }
        public Display Display { get { return display; } set { display = value; } }
        public static GSM IPhone4S { get { return iPhone4S; } }
        public List<Call> CallHistory { get { return callHistory; } set { callHistory = value; } }

    
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("Price must be greater than 0.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            Console.WriteLine("Clearing the call history...");
            CallHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0m;
            foreach (var call in callHistory)
            {
                totalPrice += (decimal)(call.Duration.TotalMinutes) * pricePerMinute;
            }
            return totalPrice;
        }

        public void PrintCallHistory()
        {
            if (!callHistory.Any())
            {
                Console.WriteLine("Call history is empty!");
            }
            else
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine(call);
                    Console.WriteLine("**************");
                }
            }
        }

        public override string ToString()
        {
            return "Mobile phone: " + Manufacturer.ToString() + " " + Model.ToString() +
                "\nPrice: " + (Price != null ? Price.ToString() + " EUR" : "<not specified>") +
                "\nOwner: " + (Owner != null ? Owner.ToString() : "<not specified>") +
                "\nBattery type: " + (Battery != null && Battery.Type != null ? Battery.Type.ToString() : "<not specified>") +
                "\nBattery model: " + (Battery != null && Battery.Model != null ? Battery.Model.ToString() : "<not specified>") +
                "\nDisplay size: " + (Display != null && Display.Size != null ? Display.Size.ToString() : "<not specified>") +
                "\nDisplay colors: " + (Display != null && Display.NumberOfColors != null ? Display.NumberOfColors.ToString() : "<not specified>") +
                "\n*****************"; 
        }
    }
}

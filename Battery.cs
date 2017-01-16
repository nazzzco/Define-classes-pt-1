namespace HomeworkDefineClass1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        public string Model { get; set; }
        public int? HoursIdle { get; set; }
        public int? HoursTalk { get; set; }
        public BatteryType? Type { get; set; }

        public Battery(string model = null, int? hoursIdle = null, int? hoursTalk = null, BatteryType? type = null)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
        MDMA
    }
}

namespace HomeworkDefineClass1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        public double? Size { get; set; }
        public int? NumberOfColors { get; set; }

        public Display(int? numberOfColors = null, double? size = null)
        {
            this.NumberOfColors = numberOfColors;
            this.Size = size;
        }
    }
}

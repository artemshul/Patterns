using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Monitor
    {
        public string screenResolution { get; set; }
        public float screenSize { get; set; }
        public int refreshRate { get; set; }

        public override string ToString()
        {
            return $"Screen resolution: {screenResolution}\nScreen size: {screenSize}\nRefresh rate: {refreshRate}";
        }
    }
}

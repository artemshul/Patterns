using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MonitorBuilder : IMonitorBuilder
    {
        Monitor monitor;
        public MonitorBuilder() 
        {
            this.monitor = new Monitor();
        }

        IMonitorBuilder IMonitorBuilder.SetScreenResolution(string screenResolution)
        {
            monitor.screenResolution = screenResolution;
            return this;
        }

        IMonitorBuilder IMonitorBuilder.SetScreenSize(float screenSize)
        {
            monitor.screenSize = screenSize;
            return this;
        }

        IMonitorBuilder IMonitorBuilder.SetRefreshRate(int refreshRate)
        {
            monitor.refreshRate = refreshRate;
            return this;
        }
        public Monitor GetMonitor()
        {
            Monitor _monitor = monitor;

            return _monitor;
        }

    }
}

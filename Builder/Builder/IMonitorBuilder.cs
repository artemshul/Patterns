using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IMonitorBuilder
    {
        IMonitorBuilder SetScreenResolution(string screenResolution);

        IMonitorBuilder SetScreenSize(float screenSize);

        IMonitorBuilder SetRefreshRate(int refreshRate);
    }
}

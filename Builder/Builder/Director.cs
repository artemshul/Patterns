using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private readonly IMonitorBuilder _builder;
        public Director(IMonitorBuilder _builder)
        {
            this._builder = _builder;
        }

        public void Build(string screenResolution, float screenSize, int refreshRate)
        {
            _builder.SetScreenResolution(screenResolution).SetScreenSize(screenSize).SetRefreshRate(refreshRate);
        }
    }
}

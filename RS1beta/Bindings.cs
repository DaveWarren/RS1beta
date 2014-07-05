using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Rockstar.Core.Game;

namespace RS1beta
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ITimeManager>().To<TimeManager>();
        }
    }
}

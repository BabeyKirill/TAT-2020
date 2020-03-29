using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._4
{
    interface IFlyable
    {
        void FlyTo(Coordinates coordinates);
        DateTime GetFlyTime(Coordinates coordinates);
    }
}
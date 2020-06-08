using System;

namespace DEV_1._4
{
    interface IFlyable
    {
        void FlyTo(Coordinates coordinates);
        DateTime GetFlyTime(Coordinates coordinates);
    }
}
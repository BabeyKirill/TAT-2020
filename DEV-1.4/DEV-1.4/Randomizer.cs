using System;

namespace DEV_1._4
{
    public static class Randomizer
    {
        public static Random random = new Random((int)DateTime.Now.Ticks);
    }
}
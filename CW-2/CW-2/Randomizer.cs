using System;

namespace CW_2
{
    public static class Randomizer
    {
        public static Random rnd = new Random((int)DateTime.Now.Ticks);
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11Excersice
{
    class Sequence
    {
        private static int currentValue = 0;
        
        private Sequence()
        {
        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}

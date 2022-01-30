using System;
namespace CreatingAndUsingObjects
{
     public static class Sequence
    {
        public static int currentValue=0;

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}

using System.Runtime.CompilerServices;

namespace assignment_1
{
    public class Range<T>  where T : IComparable<T>
    {
        
        public T Min { get;  }
        public T Max { get;  }

        public Range(T min, T max)
        {
            Min = min; Max = max;
        }

        public bool IsInRange(T first)
        {
            if (first.CompareTo(Max) > 0 || first.CompareTo(Min) < 0)
            {

                return false;
            }
            else { return true; }
        }
        
        public T Length()
        {
            dynamic min=Min;
            dynamic max = Max;

            return max-min;
        }







    }
}

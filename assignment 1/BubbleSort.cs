namespace assignment_1
{
    public class BubbleSort
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

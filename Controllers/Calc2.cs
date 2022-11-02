namespace Calc2Namespace
{
    public class Calc2
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            if( x < y)
            {
                return y - x;
            } else
            {
                return x - y;
            }
        }
    }
}


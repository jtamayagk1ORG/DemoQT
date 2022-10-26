namespace CompassNamespace
{
    public class Compass
    {
        public static String Directions(int degree)
        {
            switch (degree)
            {
                case 0: return "North";
                case 90: return "East";
                case 180: return "South";
                case 270: return "West";
                default: return "Only cardinal directions";
            }
        }
    }
}
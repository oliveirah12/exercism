public static class Darts
{
    public static int Score(double x, double y)
    {
        var distanceFromCenter = DistanceFromCenter(x, y);
        
        if (distanceFromCenter <= 1)
        {
            return 10;
        }
        else if (distanceFromCenter <= 5)
        {
            return 5;
        }
        else if (distanceFromCenter <= 10)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    private static double DistanceFromCenter(double x, double y)
    {
        return Math.Sqrt(x * x + y * y);
    }


}

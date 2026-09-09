public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int aLimit = sum / 3;

        for (int a = 1; a < aLimit; a++)
        {
            int bLimit = (sum - a - 1) / 2;

            for (int b = a + 1; b <= bLimit; b++)
            {
                int c = sum - (a + b);

                if (IsPythagoreanTriplet(a, b, c))
                {
                    yield return (a, b, c);
                }
            }
        }
    }

    private static bool IsPythagoreanTriplet(int a, int b, int c)
    {
        return a * a + b * b == c * c;
    }
}
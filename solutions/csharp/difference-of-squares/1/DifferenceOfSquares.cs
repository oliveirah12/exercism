public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var list = Enumerable.Range(1, max);
        var sum = list.Sum();

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var list = Enumerable.Range(1, max);

        return list.Sum(x => x * x);
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
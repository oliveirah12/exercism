public static class SquareRoot
{
    public static int Root(int number)
    {
        int result = 0;
        int index = 0;

        while (result <= number)
        {
            result = index * index;

            if(result == number)
                break;
            
            index++;
        }

        return index;
    }
}

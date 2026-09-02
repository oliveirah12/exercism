public static class LineUp
{
    public static string Format(string name, int number)
    {
        var position = IsFirstPositions(number);

        return $"{name}, you are the {number}{position} customer we serve today. Thank you!"; 
    }


    private static string IsFirstPositions(int number)
    {
        int suffix = number % 100;
        if (suffix == 11 || suffix == 12 || suffix == 13)
        {
            return "th";
        }

        int position = number % 10;
        switch(position)
        {
            case 1:
                return "st";
            case 2:
                return "nd";
            case 3:
                return "rd";
            default:
                return "th";
        }

        return "th";
    }
}

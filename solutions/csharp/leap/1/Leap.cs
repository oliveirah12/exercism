public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var isDivisibleBy4 = year % 4 == 0;
        var isDivisibleBy100 = year % 100 == 0;
        var isDivisibleBy400 = year % 400 == 0;

        if(year < 0)
        {
            return false;
        }

        if(isDivisibleBy400)
        { 
            return true; 
        }

        if(!isDivisibleBy400 && isDivisibleBy100)
        {
            return false;
        }

        if(isDivisibleBy4)
        {
            return true;
        }

        return false;
    }
}
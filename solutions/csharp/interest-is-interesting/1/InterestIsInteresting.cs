static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case decimal b when b < 0:
                return 3.213f;
            case decimal b when b >= 0 && b < 1000:
                return 0.5f;
            case decimal b when b >= 1000 && b < 5000:
                return 1.621f;
            default:
                return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance)/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var partialBalance = balance;
        var years = 0;


        while(partialBalance < targetBalance)
        {
            partialBalance = AnnualBalanceUpdate(partialBalance);
            years++;
        }
        return years;
    }
}

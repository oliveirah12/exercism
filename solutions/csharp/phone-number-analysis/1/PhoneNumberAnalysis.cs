public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var isNewYork = phoneNumber.StartsWith("212");
        var isFake = phoneNumber.Substring(4, 3) == "555";
        var localNumber = phoneNumber.Substring(8);

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}

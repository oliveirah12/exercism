public class Player
{
   
    private readonly Random _dice = new Random();

    public int RollDie()
    {

        return _dice.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return _dice.NextDouble() * 100;
    }
}

public class SpaceAge
{
    private double _age;
    public SpaceAge(int seconds)
    {
        _age = seconds / 31557600.0;
    }

    public double OnEarth() => _age;

    public double OnMercury() => _age / 0.2408467;

    public double OnVenus() => _age / 0.61519726;

    public double OnMars() => _age / 1.8808158;

    public double OnJupiter() => _age / 11.862615;

    public double OnSaturn() => _age / 29.447498;

    public double OnUranus() => _age / 84.016846;

    public double OnNeptune() => _age / 164.79132;
}
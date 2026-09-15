class RemoteControlCar
{
    private readonly int _speed;
    private readonly int _batteryDrain;
    private int _battery;
    private int _distance;

    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
        _distance = 0;
    }


    public void Drive()
    {
        if (BatteryDrained()) return;

        _battery -= _batteryDrain;
        _distance += _speed;
        
    }
    public bool BatteryDrained() => _battery < _batteryDrain;

    public int DistanceDriven() => _distance;

    public int TimesCarCanDrive() => 100 / _batteryDrain;

    public int MaximumDistance() => _speed * TimesCarCanDrive();

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private readonly int _distance;

    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) => car.MaximumDistance() >= _distance;

}

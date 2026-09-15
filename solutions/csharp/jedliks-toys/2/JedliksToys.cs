class RemoteControlCar
{
    private double _battery = 100;
    private double _meters = 0;

    public static RemoteControlCar Buy() => new RemoteControlCar();
    
    public string DistanceDisplay() => $"Driven {_meters} meters";

    public string BatteryDisplay()
    {
        if(_battery <= 0)
        {
            return $"Battery empty";
        }
        return $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if(_battery > 0)
        {
            _battery -= 1;
            _meters += 20;
        }

    }
}

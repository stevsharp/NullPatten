class Bus : IVehicle
{
    public static int busCount = 0;
    public Bus()
    {
        busCount++;
    }
    public void Travel()
    {
        Console.WriteLine("Let us travel with Bus");
    }
}

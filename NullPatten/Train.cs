class Train : IVehicle
{
    public static int trainCount = 0;
    public Train()
    {
        trainCount++;
    }
    public void Travel()
    {
        Console.WriteLine("Let us travel with Train");
    }
}

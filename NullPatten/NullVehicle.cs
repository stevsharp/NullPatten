
namespace NullPatten;

class NullVehicle : IVehicle
{
    private static readonly NullVehicle instance = new();
    private NullVehicle() => nullVehicleCount++;

    public static int nullVehicleCount;
    public static NullVehicle Instance => instance;

    public void Travel(){}
}

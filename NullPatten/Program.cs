
using NullPatten;

Console.WriteLine("***This program demonstrates the need of  null object pattern.* **\n");
string input = String.Empty;

while (input != "exit")
{
    Console.WriteLine("Enter your choice(Type 'a' for Bus, 'b' for Train.Type 'exit' to quit application.");
    input = Console.ReadLine();
    IVehicle vehicle = null;

    switch (input)
    {
        case "a":
            vehicle = new Bus();
            break;
        case "b":
            vehicle = new Train();
            break;
        case "exit":
            Console.WriteLine("Closing the application.");
            vehicle = NullVehicle.Instance;
            break;
    }

    var totalObjects = Bus.busCount + Train.trainCount + NullVehicle.nullVehicleCount;

    vehicle.Travel();

    Console.WriteLine($"Total objects created in the system ={totalObjects} ");
}

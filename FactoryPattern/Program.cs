namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the amount of wheels for the vehicle you wish to create");
            int wheelCount;
            var input = int.TryParse(Console.ReadLine(), out wheelCount);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}

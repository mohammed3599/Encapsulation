using Encapsulation;

namespace NameSpaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Corolla", "2017", "Silver");
            car.StartEngine();
            car.moveCar();
        }
    }
}
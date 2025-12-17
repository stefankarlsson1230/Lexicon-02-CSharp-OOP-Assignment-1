using Excercise_2;

Car car = new();
Motorbike motorbike = new();
Bus bus = new Bus();

TestDrive(car);
WriteLine();
TestDrive(motorbike);
WriteLine();
TestDrive(bus);


// Local functions
void TestDrive(IDriveable vehicle)
{
    vehicle.StartEngine();
    vehicle.Gas();
    vehicle.TurnLeft();
    vehicle.TurnRight();
    vehicle.TurnRight();
    vehicle.Brake();
    vehicle.StopEngine();
}



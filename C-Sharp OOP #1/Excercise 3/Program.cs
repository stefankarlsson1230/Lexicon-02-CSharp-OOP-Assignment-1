using Excercise_3;

Car car = new() { RemainingFuel = 30 };
Motorbike motorbike = new() { RemainingFuel = 20 };
Bus bus = new Bus() { RemainingFuel = 60 };

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



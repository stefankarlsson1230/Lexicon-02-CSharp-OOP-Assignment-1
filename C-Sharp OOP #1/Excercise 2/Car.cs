namespace Excercise_2
{
    internal class Car: IDriveable
    {
        // Properties
        public string Name { get; }
        public int VehicleSpeed { get; }
        public int RemainingFuel { get; }

        // Methods
        public void StartEngine() => WriteLine("Started the engine (Car)");
        public void StopEngine() => WriteLine("Turned off the engine (Car)");
        public void Gas() => WriteLine("Accelerated (Car)");
        public void Brake() => WriteLine("Braking (Car)");
        public void TurnLeft() => WriteLine("Turned Left (Car)");
        public void TurnRight() => WriteLine("Turned Right (Car)");
    }
}

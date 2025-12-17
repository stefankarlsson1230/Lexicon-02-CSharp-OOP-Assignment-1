namespace Excercise_2
{
    internal class Bus: IDriveable
    {
        // Properties
        public string Name { get; }
        public int VehicleSpeed { get; }
        public int RemainingFuel { get; }

        // Methods
        public void StartEngine() => WriteLine("Started the engine (Bus)");
        public void StopEngine() => WriteLine("Turned off the engine (Bus)");
        public void Gas() => WriteLine("Accelerated (Bus)");
        public void Brake() => WriteLine("Braking (Bus)");
        public void TurnLeft() => WriteLine("Turned Left (Bus)");
        public void TurnRight() => WriteLine("Turned Right (Bus)");
    }
}


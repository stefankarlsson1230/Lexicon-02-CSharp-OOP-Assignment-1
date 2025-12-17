namespace Excercise_2
{
    internal class Motorbike: IDriveable
    {
        // Properties
        public string Name { get; }
        public int VehicleSpeed { get; }
        public int RemainingFuel { get; }

        // Methods
        public void StartEngine() => WriteLine("Started the engine (Motorbike)");
        public void StopEngine() => WriteLine("Turned off the engine (Motorbike)");
        public void Gas() => WriteLine("Accelerated (Motorbike)");
        public void Brake() => WriteLine("Braking (Motorbike)");
        public void TurnLeft() => WriteLine("Turned Left (Motorbike)");
        public void TurnRight() => WriteLine("Turned Right (Motorbike)");
    }
}

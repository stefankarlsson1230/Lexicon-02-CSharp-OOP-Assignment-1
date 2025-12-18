namespace Excercise_3
{
    internal class Motorbike: EngineVehicle, IDriveable
    {
        // Properties
        public string Name { get; }
        public override int RemainingFuel
        {
            get => _remainingFuel;
            set => _remainingFuel = Math.Clamp(value, 0, 40);
        }
        public override int Speed
        {
            get => _speed;
            set => _speed = Math.Clamp(value, 0, 160);
        }

        // Methods
        public void StartEngine() => WriteLine($"Motorbike - Started the engine. Remaining fuel: {RemainingFuel} Speed: {Speed}");
        public void StopEngine() => WriteLine($"Motorbike - Turned off the engine. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        public void Gas()
        {
            Speed += 10;
            RemainingFuel -= 5;
            WriteLine($"Motorbike - Accelerated. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        }
        public void Brake()
        {
            Speed -= 10;
            WriteLine($"Motorbike - Braking. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        }
        public void TurnLeft() => WriteLine($"Motorbike - Turned Left. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        public void TurnRight() => WriteLine($"Motorbike - Turned Right. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
    }
}

namespace Excercise_3
{
    internal class Bus: EngineVehicle, IDriveable
    {
        // Properties
        public string Name { get; }
        public override int RemainingFuel
        {
            get => _remainingFuel;
            set => _remainingFuel = Math.Clamp(value, 0, 150);
        }
        public override int Speed
        {
            get => _speed;
            set => _speed = Math.Clamp(value, 0, 120);
        }

        // Methods
        public void StartEngine() => WriteLine($"Bus - Started the engine. Remaining fuel: {RemainingFuel} Speed: {Speed}");
        public void StopEngine() => WriteLine($"Bus - Turned off the engine. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        public void Gas()
        {
            Speed += 10;
            RemainingFuel -= 15;
            WriteLine($"Bus - Accelerated. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        }
        public void Brake()
        {
            Speed -= 10;
            WriteLine($"Bus - Braking. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        }
        public void TurnLeft() => WriteLine($"Bus - Turned Left. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        public void TurnRight() => WriteLine($"Bus - Turned Right. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
    }
}


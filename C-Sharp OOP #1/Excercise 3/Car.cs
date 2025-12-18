namespace Excercise_3
{
    internal class Car: EngineVehicle, IDriveable
    {
        // Properties
        public string Name { get; }
        public override int RemainingFuel
        {
            get => _remainingFuel;
            set => _remainingFuel = Math.Clamp(value, 0, 60);
        }
        public override int Speed
        {
            get => _speed;
            set => _speed = Math.Clamp(value, 0, 160);
        }
        

        // Methods
        public void StartEngine() => WriteLine($"Car - Started the engine. Remaining fuel: {RemainingFuel} Speed: {Speed}");
        public void StopEngine() => WriteLine($"Car - Turned off the engine. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        public void Gas()
        {
            Speed += 10;
            RemainingFuel -= 10;
            WriteLine($"Car - Accelerated. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        }
        public void Brake()
        {
            Speed -= 10;
            WriteLine($"Car - Braking. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        }
        public void TurnLeft() => WriteLine($"Car - Turned Left. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
        public void TurnRight() => WriteLine($"Car - Turned Right. Remaining fuel: {RemainingFuel} Speed: {Speed} (Car)");
    }
}

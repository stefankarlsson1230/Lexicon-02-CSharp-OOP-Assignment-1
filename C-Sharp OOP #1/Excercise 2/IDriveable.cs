namespace Excercise_2
{
    internal interface IDriveable
    {
        // Properties
        string Name { get; } 
        int VehicleSpeed { get; }
        int RemainingFuel { get; }

        // Methods
        void StartEngine();
        void StopEngine();
        void Gas();
        void Brake();
        void TurnLeft();
        void TurnRight();
    }
}

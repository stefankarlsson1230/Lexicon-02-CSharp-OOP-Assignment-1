namespace Excercise_3
{
    internal abstract class EngineVehicle
    {
        // Fields
        protected int _remainingFuel;
        protected int _speed;

        // Properties
        public virtual int RemainingFuel 
        {
            get => _remainingFuel;   
            set => _remainingFuel = value;
        }
        public virtual int Speed 
        { 
            get => _speed; 
            set => _speed = value;
        }


        // Constructor
        public EngineVehicle()
        {
            _remainingFuel = 0;
            _speed = 0;
        }
    }
}

namespace ImplementingISP
{
    #region
    // Because a single class can implement multiple interfaces, we are now able to pick and choose 
    // which functionality we wish to implement in each concrete implementation and we don’t 
    // need to implement functionality we don’t need in order to conform to a contract.

    // However, we do have one last issue we need to resolve.
    //
    // Our Car class, if we actually write all the code that is required, is going to be quite large 
    // (Code Smell!) and has more than one reason to change (Breaking SRP) as it is dealing with 
    // movement, sun rood controls and audio controls. 
    //
    // See Implementing the Dependency Inversion Principle.
    #endregion

    public class LuxuryCar : IAudioControl, IOperateSunRoof, IVehicle
    {
        private bool _radioOn;

        public void Accelerate()
        {
            // do something to make car go faster
        }

        public void Break()
        {
            //do something to make car slow down
        }

        public void ChangeGear(int gear)
        {
            // change to selected gear
        }

        public void TurnOnRadio()
        {
            _radioOn = true;
        }

        public void TurnOffRadio()
        {
            _radioOn = false;
        }

        public void OpenSunRoof(int percentOpen)
        {
            //Open sunroof to requested amount
        }

        public void CloseSunRoof()
        {
            //Make sunroof 100% shut (0% open)
        }
    }

    public class MotorCycle : IVehicle
    {
        public void Accelerate()
        {
            // do something to make Bike go faster 
        }

        public void Break()
        {
            // do something to make Bike slow down 
        }

        public void ChangeGear(int gear)
        {
            //change to selected gear...remember that bikes have a sequential gear box!
        }
    }

    public class BudgetCar : IVehicle
    {
        private bool _radioOn;

        public void Accelerate()
        {
            // do something to make car go faster
        }

        public void Break()
        {
            //do something to make car slow down
        }

        public void ChangeGear(int gear)
        {
            // change to selected gear
        }

        public void TurnOnRadio()
        {
            _radioOn = true;
        }

        public void TurnOffRadio()
        {
            _radioOn = false;
        }
    }
}

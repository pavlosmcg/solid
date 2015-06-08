namespace BreakingInterfaceSegregationPrinciple
{
    public class LuxuryCar : IVehicle
    {
        private bool _radioOn;

        public void Accelerate(){ 
            // do something to make car go faster
        }

        public void Brake(){
            //do something to make car slow down
        }

        public void ChangeGear(int gear){
            // change to selected gear
        }

        public void TurnOnRadio(){
            _radioOn = true;
        }
        public void TurnOffRadio(){
            _radioOn = false;
        }

        public void OpenSunRoof(int percentOpen){
            //Open sunroof to requested amount
        }

        public void CloseSunRoof(){
            //Make sunroof 100% shut (0% open)
        }
    }

    public class MotorCycle : IVehicle
    {
        public void Accelerate()
        {
            // do something to make Bike go faster 
        }

        public void Brake()
        {
            // do something to make Bike slow down 
        }

        public void ChangeGear(int gear)
        {
            //change to selected gear...remember that bikes have a sequential gear box!
        }

        public void TurnOnRadio()
        {
            throw new System.NotImplementedException("I don't have a radio - I'm a motorcycle!");
        }

        public void TurnOffRadio()
        {
            throw new System.NotImplementedException("I don't have a radio - I'm a motorcycle!");
        }

        public void OpenSunRoof(int percentOpen)
        {
            throw new System.NotImplementedException("I don't have a Sunroof - I'm a motorcycle!");
        }

        public void CloseSunRoof()
        {
            throw new System.NotImplementedException("I don't have a Sunroof - I'm a motorcycle!");
        }
    }

    public class BudgetCar : IVehicle
    {
        private bool _radioOn;

        public void Accelerate()
        {
            // do something to make car go faster
        }

        public void Brake()
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
            throw new System.NotImplementedException("I don't have a Sunroof - It was an optional extra and you didn't shell out for it!");
        }

        public void CloseSunRoof()
        {
            throw new System.NotImplementedException("I don't have a Sunroof - It was an optional extra and you didn't shell out for it!");
        }
    }
}
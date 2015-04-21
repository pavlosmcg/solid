using ImplementingISP;

namespace ImplementingDIP
{
    #region
//    Now that Dependency Inversion Principle is adhered to our LuxuryCar class:
//
//    Responsibility for the various different behaviours is abstracted out to classes that deal 
//    entirely with that behaviour, and nothing else (SRP). These could even be reused by different concrete 
//    classes. For example LuxuryCar and BudgetCar could use the same implementation of IAudioControls.
//
//    LuxuryCar is loosely coupled to the Abstractions of IVehicle, IAudioControls and IHeatedSeats instead of being tied into specific classes such as BangAndOlusenSoundSystem, for example, because we are “injecting the dependencies” rather than creating instances inside our class definition.


    #endregion

    public class LuxuryCar : IVehicle, IAudioControl, IOperateSunRoof
    {
        private readonly IVehicle _vehicleControls;
        private IAudioControl _audioControls;
        private readonly IOperateSunRoof _sunRoofControls;

        public LuxuryCar(IVehicle vehicleControls,
                    IAudioControl audioControls,
                    IOperateSunRoof sunRoofControls)
        {
            _vehicleControls = vehicleControls;
            _audioControls = audioControls;
            _sunRoofControls = sunRoofControls;
        }

        public void Accelerate()
        {
            _vehicleControls.Accelerate();
        }
        public void Break()
        {
            _vehicleControls.Break();
        }

        public void ChangeGear(int newGear)
        {
            _vehicleControls.ChangeGear(newGear);
        }

        public void TurnOnRadio()
        {
            _audioControls.TurnOnRadio();
        }

        public void TurnOffRadio()
        {
            _audioControls.TurnOffRadio();
        }
        
        public void OpenSunRoof(int percentOpen)
        {
            _sunRoofControls.OpenSunRoof(percentOpen);
        }

        public void CloseSunRoof()
        {
            _sunRoofControls.CloseSunRoof();
        }
    }
}

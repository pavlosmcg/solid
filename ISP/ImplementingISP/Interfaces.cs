namespace ImplementingISP
{
    public interface IVehicle
    {
        void Accelerate();
        void Break();
        void ChangeGear(int gear);
    }

    public interface IAudioControl
    {
        void TurnOnRadio();
        void TurnOffRadio();
    }

    public interface IOperateSunRoof
    {
        void OpenSunRoof(int percentOpen);
        void CloseSunRoof();
    }

#region
// Breaking a large interface down into smaller, more specific interfaces, based on responsibility means that each
// interface is only concerned with one responsibility (SRP – only has one reason to change).

// This gives using greater flexibility, as we can apply multiple interfaces to as class, if required, rather 
// than force as class to implement behaviour it does not need, in order to achieve Polymorphic behaviour.
#endregion
}
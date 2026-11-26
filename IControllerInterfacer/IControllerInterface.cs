using ControllerInterfacer.Enums;
using HidSharp;


namespace ControllerInterfacer
{
    public interface IControllerInterface : IDisposable
    {
        public ControllerInput ControllerInputs { get;}
        public ControllerOutput ControllerOutputs { get; set; }
        public StartupMataData StartupMetaDaten { get;}
        public event EventHandler<EventArgs> PanicStop;
        public MataData MetaDaten { get; }
        public HidDevice Device { get; } // privat set ist problem los möglich
        public MapClass IOMap { get;}

        public void SetupConnection(HidDevice device, MapClass IOMap);

        public Task RunConnection(CancellationToken cancellationToken = default);






    }
}

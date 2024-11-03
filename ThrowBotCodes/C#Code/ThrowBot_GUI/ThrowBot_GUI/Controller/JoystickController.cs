using System;
using System.Threading;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.DirectInput;

namespace ThrowBot_GUI.Controller
{
    public class JoystickController : ControllerBase
    {
        private CancellationTokenSource _cancellationTokenSource;

        private DirectInput directInput;
        private Joystick _joystick;
        private Guid joystickGuid;
        private Task USB_JoystickTask;

        public JoystickController()
        {
            directInput = new DirectInput();
        }

        public void Initialize()
        {
            // Look for connected gamepad or joystick
            joystickGuid = GetJoystickGuid();

            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("Joystick not found");
                return;
            }

            // Initialize joystick with the found GUID
            _joystick = new Joystick(directInput, joystickGuid);
            Console.WriteLine("Joystick found and initialized.");
        }

        private Guid GetJoystickGuid()
        {
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                return deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                return deviceInstance.InstanceGuid;

            // Return empty if no joystick was found
            return Guid.Empty;
        }

        public void Start()
        {
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("Cannot start: Joystick not initialized.");
                return;
            }

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            USB_JoystickTask = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    _joystick.Poll();
                    var joystickState = _joystick.GetCurrentState();
                    // Process joystick input here
                }
            }, token);
        }
    }
}

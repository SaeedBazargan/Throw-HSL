using System;
using System.Threading;
using System.Threading.Tasks;
using OpenCvSharp.Flann;
using SharpDX;
using SharpDX.DirectInput;
using static System.Windows.Forms.AxHost;

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

            _cancellationTokenSource = new CancellationTokenSource();
            USB_JoystickTask = Task.Factory.StartNew(() => Start(), _cancellationTokenSource.Token);
        }

        private Guid GetJoystickGuid()
        {
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                return deviceInstance.InstanceGuid;

            if (joystickGuid == Guid.Empty)
                // If Gamepad not found, look for a Joystick
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    return deviceInstance.InstanceGuid;

            return Guid.Empty;
        }

        private async Task Start()
        {
            DataController dataController = new DataController();

            try
            {
                _joystick = new Joystick(directInput, joystickGuid);
                Console.WriteLine("Joystick found and initialized.");
                
                _joystick.Properties.AxisMode = DeviceAxisMode.Absolute;

                _joystick.Acquire();
            }
            catch (Exception e)
            {
                Console.WriteLine("No joystick/Gamepad found!");
            }

            while (true)
            {
                try
                {
                    var joystickState = _joystick.GetCurrentState();
                    await dataController.StartJoystick(joystickState);
                }
                catch (Exception e) { }
            }
        }
    }
}

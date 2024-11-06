using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.DirectInput;
using System.Windows.Forms;

namespace ThrowBot_GUI.Controller
{
    public class JoystickConfig : ControllerBase
    {
        private Guid joystickGuid;
        private Joystick _joystick;
        private Task USB_JoystickTask;
        private DirectInput directInput;
        private Func<string, string> SendMessage;

        private CancellationTokenSource _cancellationTokenSource;

        public JoystickConfig(CancellationTokenSource cancellationTokenSource, Func<string, string> sendMessage)
        {
            directInput = new DirectInput();
            _cancellationTokenSource = cancellationTokenSource;
            SendMessage = sendMessage;
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
            USB_JoystickTask = Task.Factory.StartNew(() => Start(), _cancellationTokenSource.Token);
        }

        private Guid GetJoystickGuid()
        {
            // Look for connected gamepad or joystick
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                return deviceInstance.InstanceGuid;

            if (joystickGuid == Guid.Empty)
                // If Gamepad not found, look for a Joystick
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    return deviceInstance.InstanceGuid;

            return Guid.Empty;
        }

        private void Start()
        {
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
                return;
            }

            while (!_cancellationTokenSource.Token.IsCancellationRequested)
            {
                try
                {
                    var joystickState = _joystick.GetCurrentState();
                    GetJoystickState(joystickState);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error reading joystick state: {e.Message}");
                }
            }
        }

        private void GetJoystickState(JoystickState joystickState)
        {
            //joystickState.Buttons[0]    Button_1
            //joystickState.Buttons[1]    Button_2
            //joystickState.Buttons[2]    Button_3
            //joystickState.Buttons[3]    Button_4
            //joystickState.Buttons[4]    Button_L1
            //joystickState.Buttons[7]    Button_R2
            //joystickState.Buttons[9]    Start Button

            //joystickState.X     Left-Shock -> X
            //joystickState.Y     Left-Shock -> Y

            if (joystickState.Buttons[0]) // Button 1 press
            {
                string response = SendMessage("12346");
                Console.WriteLine($"Received message: {response}");
            }
            else if (joystickState.Buttons[9]) // Start Button
            {
                Environment.Exit(0);
            }
        }
    }
}

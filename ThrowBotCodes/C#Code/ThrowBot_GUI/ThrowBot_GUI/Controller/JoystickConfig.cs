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
        private Label _presentSpeed1_label, _presentSpeed2_label, _grayEn_label, _LED1_label, _LED2_label;

        private CancellationTokenSource _cancellationTokenSource;

        private string response;
        private byte robotSpeed  = 0;        // Low-Speed
        private bool robotMoving = false;
        private bool grayMode    = false;
        private bool LED_State   = false;



        public JoystickConfig(CancellationTokenSource cancellationTokenSource, Func<string, string> sendMessage, Label presentSpeed1_label, Label presentSpeed2_label, Label grayEn_label, Label led1_label, Label led2_label)
        {
            directInput = new DirectInput();
            _cancellationTokenSource = cancellationTokenSource;
            SendMessage = sendMessage;
            _presentSpeed1_label = presentSpeed1_label;
            _presentSpeed2_label = presentSpeed2_label;
            _grayEn_label = grayEn_label;
            _LED1_label = led1_label;
            _LED2_label = led2_label;
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

            //joystickState.X             Left-Shock -> X
            //joystickState.Y             Left-Shock -> Y

            if (joystickState.Buttons[0]) // Button 1 -> Gray Scale
            {
                grayMode = !grayMode;
                Thread.Sleep(500);
                switch (grayMode)
                {
                    case false:
                        response = SendMessage("Gray_OFF");
                        ChangeLabel(_grayEn_label, "Disable");
                        break;
                    case true:
                        response = SendMessage("Gray_ON");
                        ChangeLabel(_grayEn_label, "Enable");
                        break;
                }
            }
            else if (joystickState.Buttons[1]) // Button 2 -> LED State
            {
                LED_State = !LED_State;
                Thread.Sleep(500);
                switch (LED_State)
                {
                    case false:
                        response = SendMessage("LED_OFF");
                        ChangeLabel(_LED1_label, "OFF");
                        ChangeLabel(_LED2_label, "OFF");
                        break;
                    case true:
                        response = SendMessage("LED_ON");
                        ChangeLabel(_LED1_label, "ON");
                        ChangeLabel(_LED2_label, "ON");
                        break;
                }
            }
            // <---- -------------------------------------- ---->
            else if (joystickState.Buttons[4]) // Button L1 -> Robot Speed
            {
                robotSpeed++;
                Thread.Sleep(500);
                switch (robotSpeed)
                {
                    case 1:
                        response = SendMessage("MidSpeed");
                        ChangeLabel(_presentSpeed1_label, "Mid");
                        ChangeLabel(_presentSpeed2_label, "Mid");
                        break;
                    case 2:
                        response = SendMessage("HighSpeed");
                        ChangeLabel(_presentSpeed1_label, "High");
                        ChangeLabel(_presentSpeed2_label, "High");
                        break;
                    case 3:
                        response = SendMessage("LowSpeed");
                        ChangeLabel(_presentSpeed1_label, "Low");
                        ChangeLabel(_presentSpeed2_label, "Low");
                        robotSpeed = 0;
                        break;
                }
            }
            // <---- -------------------------------------- ---->
            else if ((joystickState.X > 32000 && joystickState.X < 33000) && (joystickState.Y > 32000 && joystickState.Y < 33000))
            {
                if (robotMoving == true)
                {
                    response = SendMessage("Stop_Dynamixel");
                    robotMoving = false;
                }
            }
            else if (joystickState.Y > 60000)
            {
                if (robotMoving == false)
                {
                    response = SendMessage("Backward");
                    robotMoving = true;
                }
            }
            else if (joystickState.Y < 1000)
            {
                if (robotMoving == false)
                {
                    response = SendMessage("Forward");
                    robotMoving = true;
                }
            }
            else if (joystickState.X > 60000)
            {
                if (robotMoving == false)
                {
                    response = SendMessage("Rightward");
                    robotMoving = true;
                }
            }
            else if (joystickState.X < 1000)
            {
                if (robotMoving == false)
                {
                    response = SendMessage("Leftward");
                    robotMoving = true;
                }
            }
            // <---- -------------------------------------- ---->
            else if (joystickState.Buttons[9]) // Start Button -> Exit
            {
                Environment.Exit(0);
            }
            // < ---------------------------------------------->
        }
    }
}

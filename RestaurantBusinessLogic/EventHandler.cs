//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RestaurantBusinessLogic
//{
//    public class InputParams : EventArgs
//    {
//        private string input;
//        public string Input
//        {
//            set { input = value; }
//            get { return this.input; }
//        }
//    }

//    public class InputEvent
//    {
//        public event InputHandler Input;
//        public delegate void InputHandler(InputEvent m, InputParams e);
//        public void Start(string input)
//        {
//            if (Input != null)
//            {
//                InputParams ip = new InputParams();
//                ip.Input = input;
//                Input(this, ip);
//            }
//        }
//    }

//    public class Listener
//    {
//        public void Subscribe(InputEvent m)
//        {
//            m.Input += new InputEvent.InputHandler(ReceivedInput);
//        }
//        private void ReceivedInput(InputEvent m, InputParams e)
//        {
//            System.Console.WriteLine("GOT INPUT {0}", e.Input);
//        }

//    }

//    static public class init
//    {
//        async static public void start(string input)
//        {
//            InputEvent m = new InputEvent();
//            Listener l = new Listener();
//            l.Subscribe(m);
//            await Task.Run(() => { m.Start(input); });
//        }
//    }
//}

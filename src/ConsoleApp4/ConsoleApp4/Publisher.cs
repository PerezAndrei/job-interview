using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Publisher
    {
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);
        public event EventHandler<CustomEventArgs> raiseCustomEvent;
        public event SampleEventHandler SampleEvent;
        public void DoSomethig()
        {
            OnRaiseCustomEventHandler(new CustomEventArgs("Event triggered"));

        }

        protected void OnRaiseCustomEventHandler(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> raiseEvent = raiseCustomEvent;
            if (raiseEvent != null)
            {
                e.Message += $" at {DateTime.Now}";
                raiseCustomEvent.Invoke(this, e);
            }
        }
    }

    public class SampleEventArgs
    {
        public SampleEventArgs(string text) { Text = text; }
        public string Text { get; } // readonly
    }

    public class Subscriber
    {
        public string Id { get; set; }
        public Subscriber(string id, Publisher pub)
        {
            Id = id;
            pub.raiseCustomEvent += HandleEvent;
        }

        private void HandleEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"{Id} recieved a message {e.Message}");
        }
    }

    public class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }
        public CustomEventArgs(string msg)
        {
            Message = msg;
        }
    }
}

using EasyNetQ;
using Messages;
using System;

namespace Publisher
{
    public class SyncPublish:ISyncPublish
    {
        private IBus _bus { get; set; }

        public SyncPublish(IBus bus)
        {
            _bus = bus;
        }
        public void SendOutMessages()
        {
            for (int i = 0; i < 10; i++)
            {
                _bus.Publish(new TextMessage
                {
                    Text = i + "-Hello!!"
                });
            }
        }

        public void ReadAndSend()
        {
            var intput = "";
            Console.WriteLine("Enter a message. 'Quit' to quit");
            while ((intput = Console.ReadLine()) != "Quit")
            {
                _bus.Publish(new TextMessage
                {
                    Text = intput
                });
            }
        }

    }
}

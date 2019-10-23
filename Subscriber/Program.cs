using EasyNetQ;
using Messages;
using System;

namespace Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost:5672;username=admin;password=admin;prefetchcount=10;virtualHost=/;timeout=60"))
            {
                bus.Subscribe<TextMessage>("Test", HandleTextMessage);
                Console.WriteLine("Listening for messages. Hit 'Return' to quit");
                Console.ReadLine();
            }
        }

        static void HandleTextMessage(TextMessage textMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Got Message : {0}",textMessage.Text);
            Console.ResetColor();
        }
    }
}

using EasyNetQ;
using Messages;
using System;

namespace Publisher
{
    class Publish
    {
        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost:5672;username=admin;password=admin;prefetchcount=10;virtualHost=/;timeout=60"))
            {
                ISyncPublish syncPublish = new SyncPublish(bus);
                syncPublish.SendOutMessages();
                syncPublish.ReadAndSend();
            }
        }
    }
}

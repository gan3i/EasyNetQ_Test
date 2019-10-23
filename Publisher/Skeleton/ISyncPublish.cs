using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
    public interface ISyncPublish
    {
        void SendOutMessages();
        void ReadAndSend();
    }
}

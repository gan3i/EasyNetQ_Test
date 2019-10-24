using System;
using System.Collections.Generic;
using System.Text;

namespace Messages
{
    public class CardPaymentRequestMessage
    {
        public string  CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }
        public string Amount { get; set; }
    }
}

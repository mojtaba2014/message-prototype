using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Message_Prototype
{
    public class Message
    {
        public string MessageText { get; set; }
        public DateTime SentTime { get; set; }


        public Message()
        {
            this.MessageText = MessageText;
            this.SentTime = SentTime;
        }
    }
}
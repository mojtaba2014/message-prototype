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
        public string name { get; set; }
        public string subject { get; set; }
        public string typeOfUser { get; set; }


        //cons
        public Message(string message,DateTime sendtime,string name,string subject,string typeOfUser)
        {
            this.MessageText = MessageText;
            this.SentTime = SentTime;
            this.name = name;
            this.subject = subject;
            this.typeOfUser = typeOfUser;
        }
        public void SendMessage(Message message)
        {

        }
    }
}
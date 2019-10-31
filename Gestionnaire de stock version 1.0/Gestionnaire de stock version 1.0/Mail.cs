using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Mail
    {
        private string sender;
        private string recipient;
        private string subject;
        private string body;

        public string Sender { get => sender; set => sender = value; }
        public string Recipient { get => recipient; set => recipient = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Body { get => body; set => body = value; }

        public Mail(string senderC, string recipientC, string subjectC, string bodyC)
        {
            Sender = senderC;
            Recipient = recipientC;
            Subject = subjectC;
            Body = bodyC;
        }
    }
   
}

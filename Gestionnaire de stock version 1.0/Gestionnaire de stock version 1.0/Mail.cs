using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Mail
    {
        public string sender;
        public string recipient;
        public string subject;
        public string body;

        public Mail(string senderC, string recipientC, string subjectC, string bodyC)
        {
            sender = senderC;
            recipient = recipientC;
            subject = subjectC;
            body = bodyC;
        }
    }
   
}

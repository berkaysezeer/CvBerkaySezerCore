using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterMessage
    {

        public int Id { get; set; }
        public string Sender { get; set; }
        public string SenderFullName { get; set; }
        public string ReceiverFullName { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; } = false;
        public bool IsReceiverDelete { get; set; } = false;
        public bool IsSenderDelete { get; set; } = false;
    }
}

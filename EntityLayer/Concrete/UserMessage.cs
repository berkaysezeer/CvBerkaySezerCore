using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserMessage
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsRead { get; set; } = false;
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inquiries:BaseEntity
    {

        private Users userID;
        private Cars carID;
        private string message;
        private DateTime inquiriesdate;

        public Users UserID { get => userID; set => userID = value; }
        public Cars CarID { get => carID; set => carID = value; }
        public string Message { get => message; set => message = value; }
        public DateTime Inquiriesdate { get => inquiriesdate; set => inquiriesdate = value; }
    }
}

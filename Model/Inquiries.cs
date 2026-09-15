using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inquiries:BaseEntity
    {

        private Users userId;
        private Cars carId;
        private string message;
        private DateTime InquiriesDate;

        public Users UserId { get => userId; set => userId = value; }
        public Cars CarId { get => carId; set => carId = value; }
        public string Message { get => message; set => message = value; }
        public DateTime InquiriesDate1 { get => InquiriesDate; set => InquiriesDate = value; }
    }
}

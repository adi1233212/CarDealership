using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Favorites:BaseEntity
    {

        private Users userID;
        private Cars carID;

        public Users UserID { get => userID; set => userID = value; }
        public Cars CarID { get => carID; set => carID = value; }
    }
}

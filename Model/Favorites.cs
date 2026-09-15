using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Favorites:BaseEntity
    {

        private Users userId;
        private Cars carId;

        public Users UserId { get => userId; set => userId = value; }
        public Cars CarID { get => carId; set => carId = value; }
    }
}

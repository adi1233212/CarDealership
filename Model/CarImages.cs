using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarImages:BaseEntity
    {

        private Cars carID;
        private string imageURL;

        public Cars CarID { get => carID; set => carID = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
    }
}

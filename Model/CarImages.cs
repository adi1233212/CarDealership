using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarImages:BaseEntity
    {

        private Cars carId;
        private string imageURL;

        public Cars CarId { get => carId; set => carId = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
    }
}

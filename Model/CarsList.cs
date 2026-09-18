using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarsList : List<Cars>
    {
        public CarsList() { }

        public CarsList(IEnumerable<Cars> list) : base(list) { }

        public CarsList(IEnumerable<BaseEntity> list)   :base(list.Cast<Cars>().ToList()) { }


    }
}

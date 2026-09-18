using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarImagesList : List<CarImages>
    {
        public CarImagesList() { }

        public CarImagesList(IEnumerable<CarImages> list) : base(list) { }

        public CarImagesList(IEnumerable<BaseEntity> list) : base(list.Cast<CarImages>().ToList()) { }


    }
}

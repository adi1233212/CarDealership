using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ElectricCarsList : List<ElectricCars>
    {

        public ElectricCarsList() { }

        public ElectricCarsList(IEnumerable<ElectricCars> list) : base(list) { }

        public ElectricCarsList(IEnumerable<BaseEntity> list) : base(list.Cast<ElectricCars>().ToList()) { }

    }
}

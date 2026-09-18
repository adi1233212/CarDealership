using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SalesList : List<Sales>
    {

        public SalesList() { }

        public SalesList(IEnumerable<Sales> list) : base(list) { }

        public SalesList(IEnumerable<BaseEntity> list) : base(list.Cast<Sales>().ToList()) { }

    }
}

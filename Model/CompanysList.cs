using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CompanysList : List<Companys>
    {

        public CompanysList() { }

        public CompanysList(IEnumerable<Companys> list) : base(list) { }

        public CompanysList(IEnumerable<BaseEntity> list) : base(list.Cast<Companys>().ToList()) { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InquiriesList : List<Inquiries>
    {

        public InquiriesList() { }

        public InquiriesList(IEnumerable<Inquiries> list) : base(list) { }

        public InquiriesList(IEnumerable<BaseEntity> list) : base(list.Cast<Inquiries>().ToList()) { }

    }
}

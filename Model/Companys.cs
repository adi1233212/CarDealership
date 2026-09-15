using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Companys:BaseEntity
    {

        private string companyName;

        public string CompanyName { get => companyName; set => companyName = value; }
    }
}

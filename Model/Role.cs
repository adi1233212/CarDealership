using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Role:BaseEntity
    {

        private string roleName;

        public string RoleName { get => roleName; set => roleName = value; }
    }
}

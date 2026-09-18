using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class RoleDB : BaseDB
    {
        public RoleList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Role";
            RoleList roleLst = new RoleList(base.Select());
            return roleLst;
        }

        public override BaseEntity NewEntity()
        {
            return new Role();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Role r = entity as Role;
            r.RoleName = reader["RoleName"].ToString();
            base.CreateModel(entity);
            return r;
        }

    }
}

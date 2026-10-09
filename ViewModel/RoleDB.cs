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

        static private RoleList list = new RoleList();

        public static Role SelectById(int id)
        {
            RoleDB roleDB = new RoleDB();
            list = roleDB.SelectAll();

            Role r = list.Find(item => item.Id == id);
            return r;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Role r = entity as Role;
            r.RoleName = reader["RoleName"].ToString();
            base.CreateModel(entity);
            return r;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Role r = entity as Role;
            if (r != null)
            {
                string sqlStr = $"UPDATE Role SET RoleName = @RoleName WHERE ID=@ID ";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@UserID", r.RoleName));
                command.Parameters.Add(new OleDbParameter("@ID", r.Id));
            }
        }
    }
}

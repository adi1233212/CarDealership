using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class UsersDB : BaseDB
    {
        public UsersList SelectAll()
        {
                command.CommandText = $"SELECT * FROM Users";
                UsersList userList = new UsersList(base.Select());
                return userList;
         }

        public override BaseEntity NewEntity()
        {
            return new Users();
        }

        static private UsersList list = new UsersList();

        public static Users SelectById(int id)
        {
            UsersDB userDB = new UsersDB();
            list = userDB.SelectAll();

            Users u = list.Find(item => item.Id == id);
            return u;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Users u = entity as Users;
            u.Name = reader["Name"].ToString();
            u.Email = reader["Email"].ToString();
            u.Pass = reader["Pass"].ToString();
            u.RoleID = RoleDB.SelectById((int)reader["RoleID"]);
            u.IsActive =bool.Parse(reader["IsActive"].ToString());
            base.CreateModel(entity);
            return u;
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
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"UPDATE Users SET Name = @Name , Email =@Email , Pass =@Pass , RoleID =@RoleID , IsActive =@IsActive  WHERE ID=@ID ";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Name", u.Name));
                command.Parameters.Add(new OleDbParameter("@Email", u.Email));
                command.Parameters.Add(new OleDbParameter("@Pass", u.Pass));
                command.Parameters.Add(new OleDbParameter("@RoleID", u.RoleID));
                command.Parameters.Add(new OleDbParameter("@IsActive", u.IsActive));
                command.Parameters.Add(new OleDbParameter("@ID", u.Id));
            }
        }
    }
}
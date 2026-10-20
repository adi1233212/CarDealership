using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace ViewModel
{
    public class InquiriesDB:BaseDB
    {

        public InquiriesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Inquiries";
            InquiriesList inquirieslist = new InquiriesList(base.Select());
            return inquirieslist;
        }

        public override BaseEntity NewEntity()
        {
            return new Inquiries();
        }

        static private InquiriesList list = new InquiriesList();

        public static Inquiries SelectById(int id)
        {
            InquiriesDB inquiriesDB = new InquiriesDB();
            list = inquiriesDB.SelectAll();

            Inquiries i = list.Find(item => item.Id == id);
            return i;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Inquiries i = entity as Inquiries;
            i.UserID = UsersDB.SelectById((int)reader["UserID"]);
            i.CarID = CarsDB.SelectById(int.Parse(reader["CarID"].ToString()));
            i.Message = reader["Message"].ToString();
            i.Inquiriesdate =DateTime.Parse(reader["InquiriesDate"].ToString());

            base.CreateModel(entity);
            return i;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Inquiries i = entity as Inquiries;

            if (i != null)
            {

                string sqlStr = $"Insert INTO Inquiries (UserID,CarID,Message,InquiriesDate)" +
                    $" VALUES (@UserID,@CarID,@Message,@InquiriesDate)";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@UserID", i.UserID.Id));
                command.Parameters.Add(new OleDbParameter("@CarID", i.CarID.Id));
                command.Parameters.Add(new OleDbParameter("@Message", i.Message));

                OleDbParameter dateParam = new OleDbParameter("@InquiriesDate", OleDbType.Date);
                dateParam.Value = i.Inquiriesdate;
                command.Parameters.Add(dateParam);

                command.Parameters.Add(new OleDbParameter("@ID", i.Id));
            }
        }


        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Inquiries i = entity as Inquiries;

            if (i != null)
            {
                string sqlStr = @"UPDATE Inquiries
                          SET UserID = ?, CarID = ?, [Message] = ?, InquiriesDate = ?
                          WHERE ID = ?";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@UserID", i.UserID.Id));
                command.Parameters.Add(new OleDbParameter("@CarID", i.CarID.Id));
                command.Parameters.Add(new OleDbParameter("@Message", i.Message));

                OleDbParameter dateParam = new OleDbParameter("@InquiriesDate", OleDbType.Date);
                dateParam.Value = i.Inquiriesdate;
                command.Parameters.Add(dateParam);

                command.Parameters.Add(new OleDbParameter("@ID", i.Id));
            }
        }


    }
}

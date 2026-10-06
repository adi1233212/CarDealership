using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
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
            i.Message = reader["CarID"].ToString();
            i.Inquiriesdate =DateTime.Parse(reader["InquiriesDate"].ToString());

            base.CreateModel(entity);
            return i;
        }

    }
}

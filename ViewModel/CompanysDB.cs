using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class CompanysDB : BaseDB
    {
        public CompanysList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Companys";
            CompanysList companysLst = new CompanysList(base.Select());
            return companysLst;
        }

        public override BaseEntity NewEntity()
        {
            return new Companys();
        }

        static private CompanysList list = new CompanysList();

        public static Companys SelectById(int id)
        {
            CompanysDB companysDB = new CompanysDB();
            list = companysDB.SelectAll();

            Companys c = list.Find(item => item.Id == id);
            return c;
        }


        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Companys c = entity as Companys;
            c.CompanyName = reader["CompanyName"].ToString();
            base.CreateModel(entity);
            return c;
        }


    }
}

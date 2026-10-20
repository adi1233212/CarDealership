using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CarsDB : BaseDB
    {

        public CarsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Cars";
            CarsList carslist = new CarsList(base.Select());
            return carslist;
        }

        public override BaseEntity NewEntity()
        {
            return new Cars();
        }

        static private CarsList list = new CarsList();

        public static Cars SelectById(int id)
        {
            CarsDB carsDB = new CarsDB();
            list = carsDB.SelectAll();

            Cars c = list.Find(item => item.Id == id);
            return c;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Cars c = entity as Cars;
            c.Company = CompanysDB.SelectById((int)reader["Company"]);
            c.Model = reader["Model"].ToString();
            c.Price = int.Parse(reader["Price"].ToString());
            c.CarYear =int.Parse(reader["CarYear"].ToString());
            c.CarNumber =reader["CarNumber"].ToString();
            c.Description = reader["Description"].ToString();
            c.OwnerShip = reader["OwnerShip"].ToString();
            c.Kilometers = int.Parse(reader["Kilometers"].ToString());
            c.IsSold = bool.Parse(reader["IsSold"].ToString());
            base.CreateModel(entity);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cars c = entity as Cars;

            if (c != null)
            {
                string sqlStr = $"Insert INTO Cars (Company,Model,Price,CarYear,CarNumber,Description,OwnerShip,Kilometers,IsSold)" +
                    $" VALUES (@Company,@Model,@Price,@CarYear,@CarNumber,@Description,@OwnerShip,@Kilometers,@IsSold)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new OleDbParameter("@Company", c.Company.Id));
                cmd.Parameters.Add(new OleDbParameter("@Model", c.Model));
                cmd.Parameters.Add(new OleDbParameter("@Price", c.Price));
                cmd.Parameters.Add(new OleDbParameter("@CarYear", c.CarYear));
                cmd.Parameters.Add(new OleDbParameter("@CarNumber", c.CarNumber));
                cmd.Parameters.Add(new OleDbParameter("@Description", c.Description));
                cmd.Parameters.Add(new OleDbParameter("@OwnerShip", c.OwnerShip));
                cmd.Parameters.Add(new OleDbParameter("@Kilometers", c.Kilometers));
                cmd.Parameters.Add(new OleDbParameter("@IsSold", c.IsSold));
                cmd.Parameters.Add(new OleDbParameter("@ID", c.Id));
            }
        }


        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cars c = entity as Cars;

            if (c != null)
            {
                string sqlStr = @"UPDATE Cars
                          SET Company = ?, Model = ?, Price = ?,
                              CarYear = ?, CarNumber = ?, [Description] = ?,
                              OwnerShip = ?, Kilometers = ?, IsSold = ?
                          WHERE ID = ?";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new OleDbParameter("@Company", c.Company.Id));
                cmd.Parameters.Add(new OleDbParameter("@Model", c.Model));
                cmd.Parameters.Add(new OleDbParameter("@Price", c.Price));
                cmd.Parameters.Add(new OleDbParameter("@CarYear", c.CarYear));
                cmd.Parameters.Add(new OleDbParameter("@CarNumber", c.CarNumber));
                cmd.Parameters.Add(new OleDbParameter("@Description", c.Description));
                cmd.Parameters.Add(new OleDbParameter("@OwnerShip", c.OwnerShip));
                cmd.Parameters.Add(new OleDbParameter("@Kilometers", c.Kilometers));
                cmd.Parameters.Add(new OleDbParameter("@IsSold", c.IsSold));
                cmd.Parameters.Add(new OleDbParameter("@ID", c.Id));
            }
        }

    }
}

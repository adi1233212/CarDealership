using Model;
using System;
using System.Collections.Generic;
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

    }
}

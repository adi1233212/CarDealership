using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class ElectricCarsDB:CarsDB
    {
        public ElectricCarsList SelectAll()
        {
            command.CommandText = $"SELECT Cars.Id, Cars.Company, Cars.Model, Cars.Price," +
                $" Cars.CarYear, Cars.CarNumber, Cars.Description, Cars.Ownership, " +
                $"Cars.Kilometers, Cars.IsSold, ElectricCars.BatteryCapacity," +
                $" ElectricCars.Range,ElectricCars.[Charging Time] " +
                $"FROM (Cars INNER JOIN ElectricCars ON Cars.Id = ElectricCars.Id)";

            ElectricCarsList ecars = new ElectricCarsList(base.Select());
            return ecars;
        }

        public override BaseEntity NewEntity()
        {
            return new ElectricCars();
        }

        static private ElectricCarsList list = new ElectricCarsList();

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            ElectricCars ec = entity as ElectricCars;
            
            ec.BatteryCapacity = int.Parse(reader["BatteryCapacity"].ToString());
            ec.Range = int.Parse(reader["Range"].ToString());
            ec.ChargingTime = reader["Charging Time"].ToString();
            base.CreateModel(entity);
            return ec;
        }


    }
}

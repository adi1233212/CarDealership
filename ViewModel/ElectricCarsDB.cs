using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class ElectricCarsDB : CarsDB
    {
        public ElectricCarsList SelectAll()
        {
            command.CommandText = $"SELECT Cars.Id, Cars.Company, Cars.Model, Cars.Price," +
                $" Cars.CarYear, Cars.CarNumber, Cars.Description, Cars.Ownership, " +
                $"Cars.Kilometers, Cars.IsSold, ElectricCars.BatteryCapacity," +
                $" ElectricCars.Range,ElectricCars.[ChargingTime] " +
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
            ec.ChargingTime = reader["ChargingTime"].ToString();
            base.CreateModel(entity);
            return ec;
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ElectricCars ec = entity as ElectricCars;
            if (ec != null)
            {
                string sqlStr = $"UPDATE ElectricCars SET BatteryCapacity = @BatteryCapacity , Range = @Range , ChargingTime = @ChargingTime WHERE ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@OwnerShip", ec.OwnerShip));
                command.Parameters.Add(new OleDbParameter("@Kilometers", ec.Kilometers));
                command.Parameters.Add(new OleDbParameter("@BatteryCapacity", ec.BatteryCapacity));
                command.Parameters.Add(new OleDbParameter("@Range", ec.Range));
                command.Parameters.Add(new OleDbParameter("@ChargingTime", ec.ChargingTime));
            }
        }

        public override void Update(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ElectricCars ec = entity as ElectricCars;
            if (ec != null)
            {
                string sqlStr = @"INSERT INTO ElectricCars
            (ID, BatteryCapacity, [Range], [ChargingTime])
            VALUES (?, ?, ?, ?)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new OleDbParameter("@ID", ec.Id));
                cmd.Parameters.Add(new OleDbParameter("@BatteryCapacity", ec.BatteryCapacity));
                cmd.Parameters.Add(new OleDbParameter("@Range", ec.Range));
                cmd.Parameters.Add(new OleDbParameter("@ChargingTime", ec.ChargingTime));
            }
        }




        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();

                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
        }

    }
}

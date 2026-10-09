using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SalesDB : CarsDB
    {
        public SalesList SelectAll()
        {
            command.CommandText = $"SELECT Cars.Id, Cars.Company, Cars.Model, Cars.Price," +
                $" Cars.CarYear, Cars.CarNumber, Cars.Description, Cars.Ownership, Cars.Kilometers," +
                $" Cars.IsSold, Sales.SalePrice, Sales.SaleDate"+
                $" FROM(Cars INNER JOIN Sales ON Cars.Id = Sales.Id)";

            SalesList sales = new SalesList(base.Select());
            return sales;
        }

        public override BaseEntity NewEntity()
        {
            return new Sales();
        }

        static private SalesList list = new SalesList();

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Sales s = entity as Sales;
            s.SalePrice = int.Parse(reader["SalePrice"].ToString());
            s.SaleDate= DateTime.Parse(reader["SaleDate"].ToString());
            base.CreateModel(entity);
            return s;
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Sales s = entity as Sales;
            if (s != null)
            {
                string sqlStr = $"UPDATE Sales SET SalePrice = @SalePrice , SaleDate = @SaleDate WHERE ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Price", s.Price));
                command.Parameters.Add(new OleDbParameter("@SalePrice", s.SalePrice));
                command.Parameters.Add(new OleDbParameter("@SaleDate", s.SaleDate));
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



    }
}

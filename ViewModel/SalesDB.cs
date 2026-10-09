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



    }
}

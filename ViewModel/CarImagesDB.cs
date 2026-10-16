using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class CarImagesDB:BaseDB
    {

        public CarImagesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM CarImages";
            CarImagesList carImagesList = new CarImagesList(base.Select());
            return carImagesList;
        }

        public override BaseEntity NewEntity()
        {
            return new CarImages();
        }

        static private CarImagesList list = new CarImagesList();

        public static CarImages SelectById(int id)
        {
            CarImagesDB carImagesDB = new CarImagesDB();
            list = carImagesDB.SelectAll();

            CarImages ci = list.Find(item => item.Id == id);
            return ci;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            CarImages ci = entity as CarImages;
            ci.CarID = CarsDB.SelectById(int.Parse(reader["CarID"].ToString()));
            ci.ImageURL = reader["ImageURL"].ToString();
            base.CreateModel(entity);
            return ci;
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
            CarImages ci = entity as CarImages;

            if (ci != null)
            {
                string sqlStr = "UPDATE CarImages SET CarID = ?, ImageURL = ? WHERE ID = ?";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new OleDbParameter("@CarID", ci.CarID.Id));
                cmd.Parameters.Add(new OleDbParameter("@ImageURL", ci.ImageURL));
                cmd.Parameters.Add(new OleDbParameter("@ID", ci.Id));
            }
        }

    }

}

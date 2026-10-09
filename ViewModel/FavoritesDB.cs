using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class FavoritesDB:BaseDB
    {

        public FavoritesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Favorites";
            FavoritesList favoritesList = new FavoritesList(base.Select());
            return favoritesList;
        }

        public override BaseEntity NewEntity()
        {
            return new Favorites();
        }

        static private FavoritesList list = new FavoritesList();

        public static Favorites SelectById(int id)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            list = favoritesDB.SelectAll();

            Favorites f = list.Find(item => item.Id == id);
            return f;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Favorites f = entity as Favorites;
            f.UserID = UsersDB.SelectById((int)reader["UserID"]);
            f.CarID = CarsDB.SelectById(int.Parse(reader["CarID"].ToString()));
            base.CreateModel(entity);
            return f;
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
            Favorites f = entity as Favorites;
            if (f != null)
            {
                string sqlStr = $"UPDATE Favorites SET UserID = @UserID , CarID = @CarID  WHERE ID=@ID ";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@UserID", f.UserID));
                command.Parameters.Add(new OleDbParameter("@CarID", f.CarID));
                command.Parameters.Add(new OleDbParameter("@ID", f.Id));
            }
        }
    }

}

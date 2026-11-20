using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiInsert : ControllerBase
    {
        [HttpPost]
        public int InsertRole(Role role)
        {
            RoleDB roleDB = new RoleDB();
            roleDB.Insert(role);
            int r = roleDB.SaveChanges();
            return r;
        }
        [HttpPost]
        public int InsertUsers(Users users)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Insert(users);
            int u = usersDB.SaveChanges();
            return u;
        }
        [HttpPost]
        public int InsertSales(Sales sales)
        {
            SalesDB salesDB = new SalesDB();
            salesDB.Insert(sales);
            int s = salesDB.SaveChanges();
            return s;
        }
        [HttpPost]
        public int InsertInquiries(Inquiries inquiries)
        {
            InquiriesDB inquiriesDB = new InquiriesDB();
            inquiriesDB.Insert(inquiries);
            int i = inquiriesDB.SaveChanges();
            return i;
        }
        [HttpPost]
        public int InsertFavorites(Favorites favorites)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            favoritesDB.Insert(favorites);
            int f = favoritesDB.SaveChanges();
            return f;
        }
        [HttpPost]
        public int InsertElectricCars(ElectricCars electricCars)
        {
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            electricCarsDB.Insert(electricCars);
            int el = electricCarsDB.SaveChanges();
            return el;
        }
        [HttpPost]
        public int InsertCompanys(Companys companys)
        {
            CompanysDB companysDB = new CompanysDB();
            companysDB.Insert(companys);
            int c = companysDB.SaveChanges();
            return c;
        }
        [HttpPost]
        public int InsertCars(Cars cars)
        {
            CarsDB carsDB = new CarsDB();
            carsDB.Insert(cars);
            int c = carsDB.SaveChanges();
            return c;
        }
        [HttpPost]
        public int InsertCarImages(CarImages carImages)
        {
            CarImagesDB carImagesDB = new CarImagesDB();
            carImagesDB.Insert(carImages);
            int ci = carImagesDB.SaveChanges();
            return ci;
        }


    }
}

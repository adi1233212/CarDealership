using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiDelete : ControllerBase
    {

        [HttpDelete]

        public int DeleteRole(Role role)
        {
            RoleDB roleDB = new RoleDB();
            roleDB.Delete(role);
            int r = roleDB.SaveChanges();
            return r;
        }
        [HttpDelete]
        public int DeleteUsers(Users users)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Delete(users);
            int u = usersDB.SaveChanges();
            return u;
        }
        [HttpDelete]
        public int DeleteSales(Sales sales)
        {
            SalesDB salesDB = new SalesDB();
            salesDB.Delete(sales);
            int s = salesDB.SaveChanges();
            return s;
        }
        [HttpDelete]
        public int DeleteInquiries(Inquiries inquiries)
        {
            InquiriesDB inquiriesDB = new InquiriesDB();
            inquiriesDB.Delete(inquiries);
            int i = inquiriesDB.SaveChanges();
            return i;
        }
        [HttpDelete]
        public int DeleteFavorites(Favorites favorites)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            favoritesDB.Delete(favorites);
            int f = favoritesDB.SaveChanges();
            return f;
        }
        [HttpDelete]
        public int DeleteElectricCars(ElectricCars electricCars)
        {
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            electricCarsDB.Delete(electricCars);
            int el = electricCarsDB.SaveChanges();
            return el;
        }
        [HttpDelete]
        public int DeleteCompanys(Companys companys)
        {
            CompanysDB companysDB = new CompanysDB();
            companysDB.Delete(companys);
            int c = companysDB.SaveChanges();
            return c;
        }
        [HttpDelete]
        public int DeleteCars(Cars cars)
        {
            CarsDB carsDB = new CarsDB();
            carsDB.Delete(cars);
            int c = carsDB.SaveChanges();
            return c;
        }
        [HttpDelete]
        public int DeleteCarImages(CarImages carImages)
        {
            CarImagesDB carImagesDB = new CarImagesDB();
            carImagesDB.Delete(carImages);
            int ci = carImagesDB.SaveChanges();
            return ci;
        }

    }
}

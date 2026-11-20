using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiUpdate : ControllerBase
    {
        [HttpPut]
        
        public int UpdateRole(Role role)
        {
            RoleDB roleDB = new RoleDB();
            roleDB.Update(role);
            int r = roleDB.SaveChanges();
            return r;
        }
        [HttpPut]
        public int UpdateUsers(Users users)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Update(users);
            int u = usersDB.SaveChanges();
            return u;
        }
        [HttpPut]
        public int UpdateSales(Sales sales)
        {
            SalesDB salesDB = new SalesDB();
            salesDB.Update(sales);
            int s = salesDB.SaveChanges();
            return s;
        }
        [HttpPut]
        public int UpdateInquiries(Inquiries inquiries)
        {
            InquiriesDB inquiriesDB = new InquiriesDB();
            inquiriesDB.Update(inquiries);
            int i = inquiriesDB.SaveChanges();
            return i;
        }
        [HttpPut]
        public int UpdateFavorites(Favorites favorites)
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            favoritesDB.Update(favorites);
            int f = favoritesDB.SaveChanges();
            return f;
        }
        [HttpPut]
        public int UpdateElectricCars(ElectricCars electricCars)
        {
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            electricCarsDB.Update(electricCars);
            int el = electricCarsDB.SaveChanges();
            return el;
        }
        [HttpPut]
        public int UpdateCompanys(Companys companys)
        {
            CompanysDB companysDB = new CompanysDB();
            companysDB.Update(companys);
            int c = companysDB.SaveChanges();
            return c;
        }
        [HttpPut]
        public int UpdateCars(Cars cars)
        {
            CarsDB carsDB = new CarsDB();
            carsDB.Update(cars);
            int c = carsDB.SaveChanges();
            return c;
        }
        [HttpPut]
        public int UpdateCarImages(CarImages carImages)
        {
            CarImagesDB carImagesDB = new CarImagesDB();
            carImagesDB.Update(carImages);
            int ci = carImagesDB.SaveChanges();
            return ci;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiSelect : ControllerBase
    {
      [HttpGet]
        public UsersList SelectAllUsers()
        {
            UsersDB usersDB = new UsersDB();
            UsersList usersList = usersDB.SelectAll();
            return usersList;
        }

        [HttpGet]
        public SalesList SelectAllSales()
        {
            SalesDB salesDB = new SalesDB();
            SalesList salesList = salesDB.SelectAll();
            return salesList;
        }
        [HttpGet]
        public RoleList SelectAllRole()
        {
            RoleDB roleDB = new RoleDB();
            RoleList roleList = roleDB.SelectAll();
            return roleList;
        }
        [HttpGet]
        public InquiriesList SelectAllInquiries()
        {
            InquiriesDB inquiriesDB = new InquiriesDB();
            InquiriesList inquiriesList = inquiriesDB.SelectAll();
            return inquiriesList;
        }
        [HttpGet]
        public FavoritesList SelectAllFavorites()
        {
            FavoritesDB favoritesDB = new FavoritesDB();
            FavoritesList favoritesList = favoritesDB.SelectAll();
            return favoritesList;
        }
        [HttpGet]
        public ElectricCarsList SelectAllElectricCars()
        {
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            ElectricCarsList electricCarsList = electricCarsDB.SelectAll();
            return electricCarsList;
        }
        [HttpGet]
        public CompanysList SelectAllCompanys()
        {
            CompanysDB companysBD = new CompanysDB();
            CompanysList companysList = companysBD.SelectAll();
            return companysList;
        }
        [HttpGet]
        public CarsList SelectAllCars()
        {
            CarsDB carsDB = new CarsDB();
            CarsList carsList = carsDB.SelectAll();
            return carsList;
        }
        [HttpGet]
        public CarImagesList SelectAllCarImages()
        {
            CarImagesDB carImagesDB = new CarImagesDB();
            CarImagesList carImagesList = carImagesDB.SelectAll();
            return carImagesList;
        }



    }
}

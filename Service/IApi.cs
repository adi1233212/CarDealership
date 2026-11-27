using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IApi
    {
        public Task<UsersList> GetAllUsers ();
        
        public Task<int> UpdateAllUsers (Users users);

        public Task<int> InsertAllUsers(Users users);

        public Task<int> DeleteAllUsers(int id);

        public Task<SalesList> GetAllSale();

        public Task<int> UpdateAllSale(Sales sales);

        public Task<int> InsertAllSale(Sales sales);

        public Task<int> DeleteAllSales(int id);

        public Task<RoleList> GetAllRole();

        public Task<int> UpdateAllRole(Role role);

        public Task<int> InsertAllRole(Role role);

        public Task<int> DeleteAllRole(int id);

        public Task<InquiriesList> GetAllInquiries();

        public Task<int> UpdateAllInquiries(Inquiries inquiries);

        public Task<int> InsertAllInquiries(Inquiries inquiries);

        public Task<int> DeleteAllInquiries(int id);

        public Task<FavoritesList> GetAllFavorites();

        public Task<int> UpdateAllFavorites(Favorites favorites);

        public Task<int> InsertAllFavorites(Favorites favorites);

        public Task<int> DeleteAllFavorites(int id);

        public Task<ElectricCarsList> GetAllElectricCars();

        public Task<int> UpdateAllElectricCars(ElectricCars electricCars);

        public Task<int> InsertAllElectricCars(ElectricCars electricCars);

        public Task<int> DeleteAllElectricCars(int id);

        public Task<CompanysList> GetAllCompanys();

        public Task<int> UpdateAllCompanys(Companys companys);

        public Task<int> InsertAllCompanys(Companys companys);

        public Task<int> DeleteAllCompanys(int id);

        public Task<CarsList> GetAllCar();

        public Task<int> UpdateAllCar(Cars cars);

        public Task<int> InsertAllCar(Cars cars);

        public Task<int> DeleteAllCar(int id);

        public Task<CarImagesList> GetAllCarImages();

        public Task<int> UpdateAllCarImages(CarImages carImages);

        public Task<int> InsertAllCarImages(CarImages carImages);

        public Task<int> DeleteAllCarImages(int id);

    }
}

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
        public UsersList GetAllUsers ();
        
        public int UpdateAllUsers ();

        public int InsertAllUsers();

        public int DeleteAllUsers();

        public SalesList GetAllSale();

        public int UpdateAllSale();

        public int InsertAllSale();

        public int DeleteAllSales();

        public RoleList GetAllRole();

        public int UpdateAllRole();

        public int InsertAllRole();

        public int DeleteAllRole();

        public InquiriesList GetAllInquiries();

        public int UpdateAllInquiries();

        public int InsertAllInquiries();

        public int DeleteAllInquiries();

        public FavoritesList GetAllFavorites();

        public int UpdateAllFavorites();

        public int InsertAllFavorites();

        public int DeleteAllFavorites();

        public ElectricCarsList GetAllElectricCars();

        public int UpdateAllElectricCars();

        public int InsertAllElectricCars();

        public int DeleteAllElectricCars();

        public CompanysList GetAllCompanys();

        public int UpdateAllCompanys();

        public int InsertAllCompanys();

        public int DeleteAllCompanys();

        public CarsList GetAllCar();

        public int UpdateAllCar();

        public int InsertAllCar();

        public int DeleteAllCar();

        public CarImagesList GetAllCarImages();

        public int UpdateAllCarImages();

        public int InsertAllCarImages();

        public int DeleteAllCarImages();

    }
}

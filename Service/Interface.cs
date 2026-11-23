using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Interface : IApi
    {
        string uri;
        public HttpClient client;
        public Interface()
        {
            uri = "http://localhost:5047";
            client = new HttpClient();
        }
        public async Task<int> DeleteAllCar()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllCarImages()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllCompanys()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllElectricCars()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllFavorites()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllInquiries()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllRole()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllSales()
        {
            throw new NotImplementedException();
        }

        public int DeleteAllUsers()
        {
            throw new NotImplementedException();
        }

        public CarsList GetAllCar()
        {
            throw new NotImplementedException();
        }

        public CarImagesList GetAllCarImages()
        {
            throw new NotImplementedException();
        }

        public CompanysList GetAllCompanys()
        {
            throw new NotImplementedException();
        }

        public ElectricCarsList GetAllElectricCars()
        {
            throw new NotImplementedException();
        }

        public FavoritesList GetAllFavorites()
        {
            throw new NotImplementedException();
        }

        public InquiriesList GetAllInquiries()
        {
            throw new NotImplementedException();
        }

        public RoleList GetAllRole()
        {
            throw new NotImplementedException();
        }

        public SalesList GetAllSale()
        {
            throw new NotImplementedException();
        }

        public UsersList GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public int InsertAllCar()
        {
            throw new NotImplementedException();
        }

        public int InsertAllCarImages()
        {
            throw new NotImplementedException();
        }

        public int InsertAllCompanys()
        {
            throw new NotImplementedException();
        }

        public int InsertAllElectricCars()
        {
            throw new NotImplementedException();
        }

        public int InsertAllFavorites()
        {
            throw new NotImplementedException();
        }

        public int InsertAllInquiries()
        {
            throw new NotImplementedException();
        }

        public int InsertAllRole()
        {
            throw new NotImplementedException();
        }

        public int InsertAllSale()
        {
            throw new NotImplementedException();
        }

        public int InsertAllUsers()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllCar()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllCarImages()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllCompanys()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllElectricCars()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllFavorites()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllInquiries()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllRole()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllSale()
        {
            throw new NotImplementedException();
        }

        public int UpdateAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}

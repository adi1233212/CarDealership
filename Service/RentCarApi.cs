using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    public class RentCarApi : IApi
    {
        string uri;
        public HttpClient client;
        public RentCarApi()
        {
            uri = "https://localhost:5047";
            client = new HttpClient();
        }
        public async Task<int> DeleteAllCar(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/DeleteCar/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllCarImages(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteCarImages/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllCompanys(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteCompanys/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllElectricCars(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteElectricCars/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllFavorites(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteFavorites/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllInquiries(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteInquiries/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllRole(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteRole/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllSales(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteSales/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAllUsers(int id)
        {
            return (await client.DeleteAsync(uri + "/api/ApiDelete/DeleteUsers/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<CarsList> GetAllCar()
        {
            return (await client.GetFromJsonAsync<CarsList>(uri + "/api/ApiSelect/SelectAllCars"));
        }

        public async Task<CarImagesList> GetAllCarImages()
        {
           return (await client.GetFromJsonAsync<CarImagesList>(uri + "/api/ApiSelect/SelectAllCarImages"));
        }

        public async Task<CompanysList> GetAllCompanys()
        {
            return (await client.GetFromJsonAsync<CompanysList>(uri + "/api/ApiSelect/CompanysList"));
        }

        public async Task<ElectricCarsList> GetAllElectricCars()
        {
            return (await client.GetFromJsonAsync<ElectricCarsList>(uri + "/api/ApiSelect/SelectAllElectricCars"));
        }

        public async Task<FavoritesList> GetAllFavorites()
        {
            return (await client.GetFromJsonAsync<FavoritesList>(uri + "/api/ApiSelect/SelectAllFavorites"));
        }

        public async Task<InquiriesList> GetAllInquiries()
        {
            return (await client.GetFromJsonAsync<InquiriesList>(uri + "/api/ApiSelect/SelectAllInquiries"));
        }

        public async Task<RoleList> GetAllRole()
        {
           return (await client.GetFromJsonAsync<RoleList>(uri + "/api/ApiSelect/SelectAllRole"));
        }

        public async Task<SalesList> GetAllSale()
        {
           return (await client.GetFromJsonAsync<SalesList>(uri + "/api/ApiSelect/SelectAllSales"));
        }

        public async Task<UsersList> GetAllUsers()
        {
           return (await client.GetFromJsonAsync<UsersList>(uri + "/api/ApiSelect/SelectAllUsers"));
        }

        public async Task<int> InsertAllCar(Cars cars)
        {
           return (await client.PostAsJsonAsync<Cars>(uri + "/api/ApiInsert/InsertCars", cars)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllCarImages(CarImages carImages)
        {
           return (await client.PostAsJsonAsync<CarImages>(uri + "/api/ApiInsert/InsertCarImages", carImages)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllCompanys(Companys companys)
        {
            return (await client.PostAsJsonAsync<Companys>(uri + "/api/ApiInsert/Companys", companys)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllElectricCars(ElectricCars electricCars)
        {
            return (await client.PostAsJsonAsync<ElectricCars>(uri + "/api/ApiInsert/ElectricCars", electricCars)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllFavorites(Favorites favorites)
        {
            return (await client.PostAsJsonAsync<Favorites>(uri + "/api/ApiInsert/Favorites", favorites)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllInquiries(Inquiries inquiries)
        {
            return (await client.PostAsJsonAsync<Inquiries>(uri + "/api/ApiInsert/Inquiries", inquiries)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllRole(Role role)
        {
            return (await client.PostAsJsonAsync<Role>(uri + "/api/ApiInsert/Role", role)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllSale(Sales sales)
        {
            return (await client.PostAsJsonAsync<Sales>(uri + "/api/ApiInsert/Sales", sales)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAllUsers(Users users)
        {
            return (await client.PostAsJsonAsync<Users>(uri + "/api/ApiInsert/Users", users)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllCar(Cars cars)
        {
            return (await client.PutAsJsonAsync<Cars>(uri + "/api/ApiInsert/Cars",cars)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllCarImages(CarImages carImages)
        {
            return (await client.PutAsJsonAsync<CarImages>(uri + "/api/ApiInsert/CarImages", carImages)).IsSuccessStatusCode ? 1 : 0;

        }

        public async Task<int> UpdateAllCompanys(Companys companys)
        {
            return (await client.PutAsJsonAsync<Companys>(uri + "/api/ApiInsert/Companys", companys)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllElectricCars(ElectricCars electricCars)
        {
            return (await client.PutAsJsonAsync<ElectricCars>(uri + "/api/ApiInsert/ElectricCars", electricCars)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllFavorites(Favorites favorites)
        {
            return (await client.PutAsJsonAsync<Favorites>(uri + "/api/ApiInsert/Favorites", favorites)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllInquiries(Inquiries inquiries)
        {
            return (await client.PutAsJsonAsync<Inquiries>(uri + "/api/ApiInsert/Inquiries", inquiries)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllRole(Role role)
        {
            return (await client.PutAsJsonAsync<Role>(uri + "/api/ApiInsert/Role", role)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllSale(Sales sales)
        {
            return (await client.PutAsJsonAsync<Sales>(uri + "/api/ApiInsert/Sales", sales)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAllUsers(Users users)
        {
            return (await client.PutAsJsonAsync<Users>(uri + "/api/ApiInsert/Users", users)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}

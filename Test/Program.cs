using ViewModel;
using Model;
using System.Text.Json.Serialization;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Role---------------");
            RoleList roles;
            RoleDB roleDB = new RoleDB();
            roles = roleDB.SelectAll();
            foreach (Role r in roles)
            {
                Console.WriteLine($"the id is: {r.Id} the Role Name is: {r.RoleName}");
            }
            //Console.WriteLine("----------------RoleUpdate---------------");
            //Role roleToUpdate = roles[0];
            //roleToUpdate.RoleName = "א";
            //roleDB.Update(roleToUpdate);
            //int ru = roleDB.SaveChanges();
            //Console.WriteLine($"{ru} rows were updated");

            //Console.WriteLine("----------------RoleInsert---------------");
            //RoleDB rdb = new();
            //Role myrole = new Role() { RoleName = "Owner" };
            //rdb.Insert(myrole);
            //int ri = rdb.SaveChanges();
            //Console.WriteLine($"{ri} rows instred");

            //Console.WriteLine("----------------RoleDelte---------------");
            //Role r1 = roles[0];
            //rdb.Delete(r1);
            //ri = rdb.SaveChanges();
            //Console.WriteLine($"{ri} rows Delte");

            Console.WriteLine("-----------------Companys-------------------");
            CompanysList companys;
            CompanysDB companysDB = new CompanysDB();
            companys = companysDB.SelectAll();
            foreach (Companys c in companys)
            {
                Console.WriteLine($"the id is: {c.Id} the Company Name: {c.CompanyName}");
                Console.WriteLine("-------------------------------------");

            }

            //Console.WriteLine("----------------CompanysUpdate---------------");
            //Companys companysToUpdate = companys[0];
            //companysToUpdate.CompanyName = "א";
            //companysDB.Update(companysToUpdate);
            //int cu = companysDB.SaveChanges();
            //Console.WriteLine($"{cu} rows were updated");

            //Console.WriteLine("----------------CompanysInsert---------------");
            //CompanysDB cdb = new();
            //Companys myCompany = new Companys() { CompanyName = "Alfa Romeo" };
            //cdb.Insert(myCompany);
            //int ccu = cdb.SaveChanges();
            //Console.WriteLine($"{ccu} rows instred");

            //Console.WriteLine("----------------CompanysDelete---------------");
            //Companys c1 = companys[0];
            //cdb.Delete(c1);
            //int cccu = cdb.SaveChanges();
            //Console.WriteLine($"{cccu} rows Delte");

            Console.WriteLine("-----------------Users-----------------");
            UsersList users;
            UsersDB usersDB = new UsersDB();
            users = usersDB.SelectAll();
            foreach (Users u in users)
            {
                Console.WriteLine($"the user id is: {u.Id} the user Name: {u.Name} the user Email is: {u.Email} the user Pss is: {u.Pass} the user Role is: {u.RoleID.RoleName} is the user active: {u.IsActive}");
                Console.WriteLine("-------------------------------------");

            }

            //Console.WriteLine("----------------UsersUpdate---------------");
            //Users usersToUpdate = users[0];
            //usersToUpdate.Name = "א";
            //usersToUpdate.Email = "א";
            //usersToUpdate.Pass = "א";
            //usersToUpdate.RoleID.RoleName = "א";
            //usersToUpdate.IsActive = false;
            //usersDB.Update(usersToUpdate);
            //int uu = usersDB.SaveChanges();
            //Console.WriteLine($"{uu} rows were updated");

            //Console.WriteLine("----------------UsersInsert---------------");

            //UsersDB udb = new();
            //Users myUsers = new Users() { Name = "Romeo Block", Email = "fdsf", Pass = "fsdwe", RoleID = roles[1], IsActive = true };
            //udb.Insert(myUsers);
            //int uuu = udb.SaveChanges();
            //Console.WriteLine($"{uuu} rows instred");
            //Console.WriteLine("----------------UsersDelete---------------");

            //users = usersDB.SelectAll();

            //Console.WriteLine("Users count: " + users.Count);

            //if (users.Count > 0)
            //{
            //    Users u1 = users[0];

            //    usersDB.Delete(u1);

            //    int ud = usersDB.SaveChanges();

            //    Console.WriteLine($"{ud} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no users to delete");
            //}

            Console.WriteLine("----------------Cars-------------------");
            CarsList cars;
            CarsDB carsDB = new CarsDB();
            cars = carsDB.SelectAll();
            foreach (Cars c in cars)
            {
                Console.WriteLine($"the car id is: {c.Id} the car Company Name: {c.Company.CompanyName} the car Model is: {c.Model} the car Price is: {c.Price} the CarYear is: {c.CarYear} the CarNumber is: {c.CarNumber} the car Ownership is: {c.OwnerShip} the Car Kilometers is: {c.Kilometers} is the car Sold? {c.IsSold}");
                Console.WriteLine("-------------------------------------");
            }

            //Console.WriteLine("----------------CarsUpdate---------------");
            //Cars carsToUpdate = cars[0];
            //carsToUpdate.Company = companys[4];
            //carsToUpdate.Model = "א";
            //carsToUpdate.Price = 1000;
            //carsToUpdate.CarYear = 2012;
            //carsToUpdate.Description = "א";
            //carsToUpdate.OwnerShip = "05";
            //carsToUpdate.Kilometers += 960;
            //carsToUpdate.IsSold = true;
            //carsDB.Update(carsToUpdate);
            //int cc = carsDB.SaveChanges();
            //Console.WriteLine($"{cc} rows were updated");

            //Console.WriteLine("----------------CarsInsert---------------");
            //CarsDB ccdb = new();
            //Cars myCars = new Cars() { Company = companys[6], Model = "Toyota Corolla", Price = 4500, CarYear = 2021, CarNumber = "7564758", Description = "fdsfsfsd", OwnerShip = "03", Kilometers = 32421, IsSold = false };
            //ccdb.Insert(myCars);
            //int ccc = ccdb.SaveChanges();
            //Console.WriteLine($"{ccc} rows instred");
            //Console.WriteLine("----------------CarsDelete---------------");

            //cars = carsDB.SelectAll();

            //if (cars.Count > 0)
            //{
            //    Cars cc1 = cars[0];

            //    carsDB.Delete(cc1);

            //    int cccc = carsDB.SaveChanges();

            //    Console.WriteLine($"{cccc} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no cars to delete");
            //}

            Console.WriteLine("-----------------Inquiries--------------");
            InquiriesList inquiries;
            InquiriesDB inquiriesDB = new InquiriesDB();
            inquiries = inquiriesDB.SelectAll();
            foreach (Inquiries i in inquiries)
            {
                Console.WriteLine($"the user is:{i.UserID.Name},{i.UserID.Email} the car is: {i.CarID.Model},{i.CarID.Company.CompanyName},{i.CarID.Price} the massage is: {i.Message} the Inquiriesdate is: {i.Inquiriesdate.Month},{i.Inquiriesdate.Year}");
                Console.WriteLine("-------------------------------------");
            }
            //Console.WriteLine("----------------InquiriesUpdate---------------");
            //if (inquiries.Count > 0 && companys.Count > 4)
            //{
            //    Inquiries inquiriesToUpdate = inquiries[0];

            //    inquiriesToUpdate.UserID.Name = "א";
            //    inquiriesToUpdate.UserID.Email = "א";
            //    inquiriesToUpdate.CarID.Model = "א";
            //    inquiriesToUpdate.CarID.Company = companys[4];
            //    inquiriesToUpdate.CarID.Price = 1000;
            //    inquiriesToUpdate.Message = "א";
            //    inquiriesToUpdate.Inquiriesdate = DateTime.Now;

            //    inquiriesDB.Update(inquiriesToUpdate);

            //    int iu = inquiriesDB.SaveChanges();
            //    Console.WriteLine($"{iu} rows were updated");
            //}
            //else
            //{
            //    Console.WriteLine("`There are no inquiries to update or not enough companies in the list.");
            //}
            //Console.WriteLine("----------------InquiriesInsert---------------");
            //InquiriesDB indb = new();
            //Inquiries myInquiries = new Inquiries() { UserID = users[3], CarID = cars[3], Message = "vdgvfgdf", Inquiriesdate = DateTime.Now };
            //indb.Insert(myInquiries);
            //int inn = indb.SaveChanges();
            //Console.WriteLine($"{inn} rows instred");
            //Console.WriteLine("----------------InquiriesDelete---------------");

            //inquiries = inquiriesDB.SelectAll();

            //Console.WriteLine("Inquiries count: " + inquiries.Count);

            //if (inquiries.Count > 0)
            //{
            //    Inquiries i1 = inquiries[0];

            //    inquiriesDB.Delete(i1);

            //    int result = inquiriesDB.SaveChanges();

            //    Console.WriteLine($"{result} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no inquiries to delete");
            //}
            Console.WriteLine("-----------------Favorites--------------");
            FavoritesList favorites;
            FavoritesDB favoritesDB = new FavoritesDB();
            favorites = favoritesDB.SelectAll();
            foreach (Favorites ff in favorites)
            {
                Console.WriteLine($"the user is: {ff.UserID.Id},{ff.UserID.Name},{ff.UserID.Email} the car is: {ff.CarID.Id},{ff.CarID.Model},{ff.CarID.Company},{ff.CarID.Price}");
                Console.WriteLine("-------------------------------------");
            }
            //Console.WriteLine("----------------FavoritesUpdate---------------");
            //Favorites favoritesToUpdate = favorites[0];
            //favoritesToUpdate.UserID.Name = "א";
            //favoritesToUpdate.UserID.Email = "א";
            //favoritesToUpdate.CarID.Model = "א";
            //favoritesToUpdate.CarID.Company = companys[4];
            //favoritesDB.Update(favoritesToUpdate);
            //int f = favoritesDB.SaveChanges();
            //Console.WriteLine($"{f} rows were updated");

            //Console.WriteLine("----------------FavoritesInsert---------------");
            //FavoritesDB fdb = new();
            //Favorites myFavorites = new Favorites() { UserID = users[3], CarID = cars[3] };
            //fdb.Insert(myFavorites);
            //int fff = fdb.SaveChanges();
            //Console.WriteLine($"{fff} rows instred");
            //Console.WriteLine("----------------FavoritesDelete---------------");
            //favorites = favoritesDB.SelectAll();

            //if (favorites.Count > 0)
            //{
            //    Favorites f1 = favorites[0];
            //    favoritesDB.Delete(f1);
            //    int fa = favoritesDB.SaveChanges();
            //    Console.WriteLine($"{fa} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no favorites to delete");
            //}
            Console.WriteLine("-----------------CarImages--------------");
            CarImagesList carImages;
            CarImagesDB carImagesDB = new CarImagesDB();
            carImages = carImagesDB.SelectAll();
            foreach (CarImages ci in carImages)
            {
                Console.WriteLine($"the car is: {ci.CarID.Id},{ci.CarID.Model},{ci.CarID.Company},{ci.CarID.Price} and the car pic: {ci.ImageURL}");
                Console.WriteLine("-------------------------------------");
            }
            //Console.WriteLine("----------------CarImagesUpdate---------------");
            //CarImages carImagesToUpdate = carImages[0];
            //carImagesToUpdate.CarID.Model = "א";
            //carImagesToUpdate.CarID.Company = companys[4];
            //carImagesToUpdate.ImageURL = "אטקר";
            //carImagesDB.Update(carImagesToUpdate);
            //int cii = carImagesDB.SaveChanges();
            //Console.WriteLine($"{cii} rows were updated");
            //Console.WriteLine("----------------CarImagesInsert---------------");

            //CarImagesDB cidb = new CarImagesDB();

            //if (cars.Count > 0)
            //{
            //    CarImages myCarImages = new CarImages()
            //    {
            //        CarID = cars[0],
            //        ImageURL = "fsdfsdhgfsdj"
            //    };

            //    cidb.Insert(myCarImages);

            //    int cii1 = cidb.SaveChanges();

            //    Console.WriteLine($"{cii1} rows inserted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no cars in the database.");
            //}
            //Console.WriteLine("----------------CarImagesDelete---------------");

            //carImages = carImagesDB.SelectAll();

            //Console.WriteLine("CarImages count: " + carImages.Count);

            //if (carImages.Count > 0)
            //{
            //    CarImages ci1 = carImages[0];

            //    carImagesDB.Delete(ci1);

            //    int caa = carImagesDB.SaveChanges();

            //    Console.WriteLine($"{caa} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no car images to delete");
            //}
            Console.WriteLine("-----------------ElectircCars--------------");
            ElectricCarsList electricCars;
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            electricCars = electricCarsDB.SelectAll();
            foreach (ElectricCars ec in electricCars)
            {
                Console.WriteLine($"the car is: {ec.Company.CompanyName},{ec.Model} the BatteryCapacity is: {ec.BatteryCapacity} the Range is: {ec.Range} the ChargingTimeInHours is: {ec.ChargingTime}");
                Console.WriteLine("-------------------------------------");
            }
            //Console.WriteLine("----------------ElectircCarsUpdate---------------");
            //ElectricCars electricCarsToUpdate = electricCars[0];
            //electricCarsToUpdate.Model = "א";
            //electricCarsToUpdate.Company = companys[4];
            //electricCarsToUpdate.BatteryCapacity -= 65;
            //electricCarsToUpdate.Range = 65;
            //electricCarsToUpdate.ChargingTime = "4";
            //electricCarsDB.Update(electricCarsToUpdate);
            //int ecc = electricCarsDB.SaveChanges();
            //Console.WriteLine($"{ecc} rows were updated");

            //Console.WriteLine("----------------ElectircCarsInsert---------------");
            //ElectricCarsDB ecdb = new();
            //ElectricCars myElectricCars = new ElectricCars() { Company = companys[3], Model = "fsdfsdh", Price = 150000, CarYear = 2025, CarNumber = "12345678", Description = "Electric car", OwnerShip = "00", Kilometers = 0, IsSold = false, BatteryCapacity = 324, Range = 332, ChargingTime = "32" };
            //ecdb.Insert(myElectricCars);
            //int cee = ecdb.SaveChanges();
            //Console.WriteLine($"{cee} rows instred");
            //Console.WriteLine("----------------ElectircCarsDelete---------------");

            //electricCars = electricCarsDB.SelectAll();

            //Console.WriteLine("ElectricCars count: " + electricCars.Count);

            //if (electricCars.Count > 0)
            //{
            //    ElectricCars ec1 = electricCars[0];

            //    electricCarsDB.Delete(ec1);

            //    int ce = electricCarsDB.SaveChanges();

            //    Console.WriteLine($"{ce} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no electric cars to delete");
            //}
            Console.WriteLine("-----------------Sale--------------");
            SalesList sales;
            SalesDB salesDB = new SalesDB();
            sales = salesDB.SelectAll();
            foreach (Sales s in sales)
            {
                Console.WriteLine($"the car is: {s.Company.CompanyName},{s.Model} the SalePrice is: {s.SalePrice} the SaleDate is: {s.SaleDate.Day}/{s.SaleDate.Month}/{s.SaleDate.Year}");
                Console.WriteLine("-------------------------------------");
            }
            //Console.WriteLine("----------------SaleUpdate---------------");
            //Sales salesToUpdate = sales[0];
            //salesToUpdate.Model = "א";
            //salesToUpdate.Company = companys[4];
            //salesToUpdate.SalePrice -= 50;
            //salesToUpdate.SaleDate = DateTime.Now;
            //salesDB.Update(salesToUpdate);
            //int ss = electricCarsDB.SaveChanges();
            //Console.WriteLine($"{ss} rows were updated");

            //Console.WriteLine("----------------SaleInsert---------------");
            //SalesDB sidb = new();
            //Sales mySales = new Sales() { Company = companys[3], Model = "fsdfsdh", Price = 150000, CarYear = 2025, CarNumber = "12345678", Description = "Electric car", OwnerShip = "01", Kilometers = 4567, IsSold = true, SaleDate = DateTime.Now, SalePrice = 31241 };
            //sidb.Insert(mySales);
            //int ssc = sidb.SaveChanges();
            //Console.WriteLine($"{ssc} rows instred");
            //Console.WriteLine("----------------SaleDelete---------------");

            //sales = salesDB.SelectAll();

            //Console.WriteLine("Sales count: " + sales.Count);

            //if (sales.Count > 0)
            //{
            //    Sales s1 = sales[0];

            //    salesDB.Delete(s1);

            //    int sss = salesDB.SaveChanges();

            //    Console.WriteLine($"{sss} rows Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("There are no sales to delete");
            //}
        }
    }
}



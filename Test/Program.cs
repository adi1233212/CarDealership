using ViewModel;
using Model;
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
            Console.WriteLine("----------------RoleUpdate---------------");
            Role roleToUpdate = roles[0];
            roleToUpdate.RoleName = "א";
            roleDB.Update(roleToUpdate);
            int ru = roleDB.SaveChanges();
            Console.WriteLine($"{ru} rows were updated");
            foreach (Role r in roles)
            {
                Console.WriteLine($"the id is: {r.Id} the Role Name is: {r.RoleName}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------Companys-------------------");
            CompanysList companys;
            CompanysDB companysDB = new CompanysDB();
            companys = companysDB.SelectAll();
            foreach (Companys c in companys)
            {
                Console.WriteLine($"the id is: {c.Id} the Company Name: {c.CompanyName}");
                Console.WriteLine("-------------------------------------");

            }
            Console.WriteLine("----------------CompanysUpdate---------------");
            Companys companysToUpdate = companys[0];
            companysToUpdate.CompanyName = "א";
            companysDB.Update(roleToUpdate);
            int cu = companysDB.SaveChanges();
            Console.WriteLine($"{cu} rows were updated");
            foreach (Companys c in companys)
            {
                Console.WriteLine($"the id is: {c.Id} the Company Name: {c.CompanyName}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------Users-----------------");
            UsersList users;
            UsersDB usersDB = new UsersDB();
            users = usersDB.SelectAll();
            foreach (Users u in users)
            {
                Console.WriteLine($"the user id is: {u.Id} the user Name: {u.Name} the user Email is: {u.Email} the user Pss is: {u.Pass} the user Role is: {u.RoleID.RoleName} is the user active: {u.IsActive}");
                Console.WriteLine("-------------------------------------");

            }
            Console.WriteLine("----------------UsersUpdate---------------");
            Users usersToUpdate = users[0];
            usersToUpdate.Name = "א";
            usersToUpdate.Email = "א";
            usersToUpdate.Pass = "א";
            usersToUpdate.RoleID.RoleName = "א";
            usersToUpdate.IsActive = false;
            roleDB.Update(roleToUpdate);
            int uu = usersDB.SaveChanges();
            Console.WriteLine($"{uu} rows were updated");
            foreach (Users u in users)
            {
                Console.WriteLine($"the user id is: {u.Id} the user Name: {u.Name} the user Email is: {u.Email} the user Pss is: {u.Pass} the user Role is: {u.RoleID.RoleName} is the user active: {u.IsActive}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------Cars-------------------");
            CarsList cars;
            CarsDB carsDB = new CarsDB();
            cars = carsDB.SelectAll();
            foreach (Cars c in cars)
            {
                Console.WriteLine($"the car id is: {c.Id} the car Company Name: {c.Company.CompanyName} the car Model is: {c.Model} the car Price is: {c.Price} the CarYear is: {c.CarYear} the CarNumber is: {c.CarNumber} the car Ownership is: {c.OwnerShip} the Car Kilometers is: {c.Kilometers} is the car Sold? {c.IsSold}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------CarsUpdate---------------");
            Cars carsToUpdate = cars[0];
            carsToUpdate.Company = companys[4];
            carsToUpdate.Model = "א";
            carsToUpdate.Price = 1000;
            carsToUpdate.CarYear = 2012;
            carsToUpdate.Description = "א";
            carsToUpdate.OwnerShip = "05";
            carsToUpdate.Kilometers += 960;
            carsToUpdate.IsSold = true;
            carsDB.Update(carsToUpdate);
            int cc = carsDB.SaveChanges();
            Console.WriteLine($"{cc} rows were updated");
            foreach (Cars c in cars)
            {
                Console.WriteLine($"the car id is: {c.Id} the car Company Name: {c.Company.CompanyName} the car Model is: {c.Model} the car Price is: {c.Price} the CarYear is: {c.CarYear} the CarNumber is: {c.CarNumber} the car Ownership is: {c.OwnerShip} the Car Kilometers is: {c.Kilometers} is the car Sold? {c.IsSold}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------Inquiries--------------");
            InquiriesList inquiries;
            InquiriesDB inquiriesDB = new InquiriesDB();
            inquiries = inquiriesDB.SelectAll();
            foreach (Inquiries i in inquiries)
            {
                Console.WriteLine($"the user is:{i.UserID.Name},{i.UserID.Email} the car is: {i.CarID.Model},{i.CarID.Company.CompanyName},{i.CarID.Price} the massage is: {i.Message} the Inquiriesdate is: {i.Inquiriesdate.Month},{i.Inquiriesdate.Year}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------InquiriesUpdate---------------");
            if (inquiries.Count > 0 && companys.Count > 4)
{
                Inquiries inquiriesToUpdate = inquiries[0];

                inquiriesToUpdate.UserID.Name = "א";
                inquiriesToUpdate.UserID.Email = "א";
                inquiriesToUpdate.CarID.Model = "א";
                inquiriesToUpdate.CarID.Company = companys[4];
                inquiriesToUpdate.CarID.Price = 1000;
                inquiriesToUpdate.Message = "א";
                inquiriesToUpdate.Inquiriesdate = DateTime.Now;

                inquiriesDB.Update(inquiriesToUpdate);

                int iu = inquiriesDB.SaveChanges();
                Console.WriteLine($"{iu} rows were updated");
                foreach (Inquiries i in inquiries)
                {
                    Console.WriteLine($"the user is:{i.UserID.Name},{i.UserID.Email} the car is: {i.CarID.Model},{i.CarID.Company.CompanyName},{i.CarID.Price} the massage is: {i.Message} the Inquiriesdate is: {i.Inquiriesdate.Month},{i.Inquiriesdate.Year}");
                    Console.WriteLine("-------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("`There are no inquiries to update or not enough companies in the list.");
            }
            Console.WriteLine("-----------------Favorites--------------");
            FavoritesList favorites;
            FavoritesDB favoritesDB = new FavoritesDB();
            favorites = favoritesDB.SelectAll();
            foreach (Favorites ff in favorites)
            {
                Console.WriteLine($"the user is: {ff.UserID.Id},{ff.UserID.Name},{ff.UserID.Email} the car is: {ff.CarID.Id},{ff.CarID.Model},{ff.CarID.Company},{ff.CarID.Price}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------FavoritesUpdate---------------");
            Favorites favoritesToUpdate = favorites[0];
            favoritesToUpdate.UserID.Name = "א";
            favoritesToUpdate.UserID.Email = "א";
            favoritesToUpdate.CarID.Model = "א";
            favoritesToUpdate.CarID.Company = companys[4];
            favoritesDB.Update(favoritesToUpdate);
            int f = favoritesDB.SaveChanges();
            Console.WriteLine($"{f} rows were updated");
            foreach (Favorites ff in favorites)
            {
                Console.WriteLine($"the user is: {ff.UserID.Id},{ff.UserID.Name},{ff.UserID.Email} the car is: {ff.CarID.Id},{ff.CarID.Model},{ff.CarID.Company},{ff.CarID.Price}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------CarImages--------------");
            CarImagesList carImages;
            CarImagesDB carImagesDB = new CarImagesDB();
            carImages = carImagesDB.SelectAll();
            foreach (CarImages ci in carImages)
            {
                Console.WriteLine($"the car is: {ci.CarID.Id},{ci.CarID.Model},{ci.CarID.Company},{ci.CarID.Price} and the car pic: {ci.ImageURL}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------CarImagesUpdate---------------");
            CarImages carImagesToUpdate = carImages[0];
            carImagesToUpdate.CarID.Model = "א";
            carImagesToUpdate.CarID.Company = companys[4];
            carImagesToUpdate.ImageURL = "אטקר";
            carImagesDB.Update(carImagesToUpdate);
            int cii = carImagesDB.SaveChanges();
            Console.WriteLine($"{cii} rows were updated");
            foreach (CarImages ci in carImages)
            {
                Console.WriteLine($"the car is: {ci.CarID.Id},{ci.CarID.Model},{ci.CarID.Company},{ci.CarID.Price} and the car pic: {ci.ImageURL}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------ElectircCars--------------");
            ElectricCarsList electricCars;
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            electricCars = electricCarsDB.SelectAll();
            foreach (ElectricCars ec in electricCars)
            {
                Console.WriteLine($"the car is: {ec.Company.CompanyName},{ec.Model} the BatteryCapacity is: {ec.BatteryCapacity} the Range is: {ec.Range} the ChargingTimeInHours is: {ec.ChargingTime}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------ElectircCarsUpdate---------------");
            ElectricCars electricCarsToUpdate = electricCars[0];
            electricCarsToUpdate.Model = "א";
            electricCarsToUpdate.Company = companys[4];
            electricCarsToUpdate.BatteryCapacity -= 65;
            electricCarsToUpdate.Range = 65;
            electricCarsToUpdate.ChargingTime = "4";
            electricCarsDB.Update(electricCarsToUpdate);
            int ecc = electricCarsDB.SaveChanges();
            Console.WriteLine($"{ecc} rows were updated");
            foreach (ElectricCars ec in electricCars)
            {
                Console.WriteLine($"the car is: {ec.Company.CompanyName},{ec.Model} the BatteryCapacity is: {ec.BatteryCapacity} the Range is: {ec.Range} the ChargingTimeInHours is: {ec.ChargingTime}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------Sale--------------");
            SalesList sales;
            SalesDB salesDB = new SalesDB();
            sales = salesDB.SelectAll();
            foreach (Sales s in sales)
            {
                Console.WriteLine($"the car is: {s.Company.CompanyName},{s.Model} the SalePrice is: {s.SalePrice} the SaleDate is: {s.SaleDate.Day}/{s.SaleDate.Month}/{s.SaleDate.Year}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------SaleUpdate---------------");
            Sales salesToUpdate = sales[0];
            salesToUpdate.Model = "א";
            salesToUpdate.Company = companys[4];
            salesToUpdate.SalePrice -= 50;
            salesToUpdate.SaleDate = DateTime.Now;
            salesDB.Update(salesToUpdate);
            int ss = electricCarsDB.SaveChanges();
            Console.WriteLine($"{ss} rows were updated");
            foreach (Sales s in sales)
            {
                Console.WriteLine($"the car is: {s.Company.CompanyName},{s.Model} the SalePrice is: {s.SalePrice} the SaleDate is: {s.SaleDate.Day}/{s.SaleDate.Month}/{s.SaleDate.Year}");
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}

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
                Console.WriteLine($"the id is: {r.Id} the Role Name is: { r.RoleName}");
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
            Console.WriteLine("-----------------Users-----------------");
            UsersList users;
            UsersDB usersDB = new UsersDB();
            users = usersDB.SelectAll();
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
            Console.WriteLine("-----------------Inquiries--------------");
            InquiriesList inquiries;
            InquiriesDB inquiriesDB = new InquiriesDB();
            inquiries = inquiriesDB.SelectAll();
            foreach (Inquiries i in inquiries)
            {
                Console.WriteLine($"the user is: {i.UserID.Id},{i.UserID.Name},{i.UserID.Email} the car is: {i.CarID.Id},{i.CarID.Model},{i.CarID.Company},{i.CarID.Price} the massage is: {i.Message} the Inquiriesdate is: {i.Inquiriesdate}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-----------------Favorites--------------");
            FavoritesList favorites;
            FavoritesDB favoritesDB = new FavoritesDB();
            favorites = favoritesDB.SelectAll();
            foreach (Favorites f in favorites)
            {
                Console.WriteLine($"the user is: {f.UserID.Id},{f.UserID.Name},{f.UserID.Email} the car is: {f.CarID.Id},{f.CarID.Model},{f.CarID.Company},{f.CarID.Price}");
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
            Console.WriteLine("-----------------ElectircCars--------------");
            ElectricCarsList electricCars;
            ElectricCarsDB electricCarsDB = new ElectricCarsDB();
            electricCars = electricCarsDB.SelectAll();
            foreach (ElectricCars ec in electricCars)
            {
                Console.WriteLine($"the car is: {ec.Company.CompanyName},{ec.Model} the BatteryCapacity is: {ec.BatteryCapacity} the Range is: {ec.Range} the ChargingTimeInHours is: {ec.ChargingTime}");
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}

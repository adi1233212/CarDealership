using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;

namespace TestApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            RentCarApi rentCarApi = new RentCarApi();
            UsersList users = await rentCarApi.GetAllUsers();
            foreach(Users u in users)
            {
                await Console.Out.WriteLine(u.Name);
            }
        }

    }
}

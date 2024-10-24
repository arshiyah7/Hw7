using Hw7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7.Storage
{
    public static class Data
    {
        public static List<User> UserList { get; set; } = new List<User>();
        public static List<Product> ProductList { get; set; } = new List<Product>();
        public static  User currentUser { get; set; }

        static Data()
        {
            UserList.Add(new User("arshiya", "arshiyah7", "arshiyah6@gmail.com"));
            UserList.Add(new User("hassan", "hassanh7", "hassanh6@gmail.com"));
            ProductList.Add(new Product("galaxy s24" , 1 , 1000 , CategoryEnum.phone , 10));
            ProductList.Add(new Product ("iphone 16 " , 2 , 1100 , CategoryEnum.phone , 10));
            ProductList.Add(new Product ("asus" , 3 , 2000 , CategoryEnum.laptop , 10));
            ProductList.Add(new Product("s24 cover" , 4 , 50 , CategoryEnum.accesories , 10));
        }
    }
}

using Hw7.Interface;
using Hw7.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hw7.Entities
{
    public class User : IAutentication
    {
       
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; }
        public List<Product> products { get; set; } = new List<Product>();
        public List<Product> product { get; set; } = new List<Product>();
        public int ProductId { get; set; }
        public ShipingCart Cart { get; set; }

        public User(string username, string password, string email)
        {
           Username = username;
            Password = password;
            Email = email;
        }
        public User(string username , string password)
        {
            Password = password;
            Username = username;
        }
        public User(int productid)
        {
            ProductId = productid;
        }
        public User()
        {
            
        }

        public string Regester(string username, string email, string password)
        {
            User us = new User(username, email, password);
            if (username != null && password != null && (email != null))
            {

                foreach (User user in Data.UserList)
                {
                    if (username != user.Username && email != user.Email)
                    {
                        us.Password = password;
                        us.Email = email;
                        us.Username = username;
                        Data.UserList.Add(us);
                        return "successful";

                    }
                    return "email or username is exist";

                }
                return "username or password or email is null";

            }
            return "failed";
        }

        public string Login(string username, string password)
        {
            if (username != null && password != null)
            {
                foreach (User user in Data.UserList)
                {
                    if (password == user.Password && username == user.Username)
                    {
                        return "login successful";
                    }
                }
                return "password or username is empty";
            }
            return "user dosent exist please regester";
        }
        public User getUser(string username)
        {
            foreach(User user in Data.UserList)
            {
                if(user.Username == username){
                    Data.currentUser = user;
                    return user;
                }
            }
            return null;
        }
        public string AddToCart(int productid)
        {
            foreach(Product p in Data.ProductList)
            {
                if(p.ProductId == productid)
                {
                    products.Add(p);
                    return "successfuly added to your cart";
                }
            }
            return "failed";
        }
        public void SeeCart()
        {
            foreach(var item in products)
            {
                Console.WriteLine($"{item.Name} \n {item.Price} \n {item.ProductId}");
            }
        }
        public string logout()
        {
            Data.currentUser = null;
            return "successfyl";
        }
        public string Confirmation()
        {
            foreach(var item in products)
            {
                product.Add(item);
                products = null;
                return "product will send to u";
            }
            return "your cart is empty";
        }
        public void LastOrder()
        {
            foreach(var item in product)
            {
                Console.WriteLine($"{item.Name} \n {item.Price} \n {item.ProductId}");
            }
        }
    }


}


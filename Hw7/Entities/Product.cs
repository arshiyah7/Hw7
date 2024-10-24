using Hw7.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public CategoryEnum Category { get; set; }
        public int Amount { get; set; }



        public Product(string name, int productId, int price, CategoryEnum category, int amount)
        {
            Name = name;
            ProductId = productId;
            Price = price;
            Category = category;
            Amount = amount;
        }
        public Product(int productId  )
        {
            ProductId = productId; 
            
        }
        public Product()
        {
            
        }
        public void categoryList(int category)
        {
            
           
                switch (category)
                {

                    case 1:
                       foreach(var item in Data.ProductList)
                    {
                        if (item is not null)
                        {
                            if(item.Category == CategoryEnum.phone)
                            {
                                Console.WriteLine($"{item.Name } \n { item.Price} \n {item.ProductId}");
                            }
                           
                        }
                    }
                    break;
                     
                    case 2:
                    foreach (var item in Data.ProductList)
                    {
                        if (item is not null)
                        {
                            if (item.Category == CategoryEnum.laptop)
                            {
                                Console.WriteLine($"{item.Name} \n {item.Price} \n {item.ProductId}");
                            }

                        }
                    }
                    break;

                case 3:

                    foreach (var item in Data.ProductList)
                    {
                        if (item is not null)
                        {
                            if (item.Category == CategoryEnum.accesories)
                            {
                                Console.WriteLine($"{item.Name} \n {item.Price} \n {item.ProductId}");
                            }

                        }
                    }
                    break;

            }

            
           

        }
        
       
    }
}

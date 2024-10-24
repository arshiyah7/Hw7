using Hw7.Entities;
using System.Collections.Specialized;
bool repeat = true;
while (repeat)
{
    Console.WriteLine("1)login");
    Console.WriteLine("2)regester");
    int ch = int.Parse(Console.ReadLine());
    if (ch == 1)
    {
        login();
        menu();
        Console.WriteLine("do u want to continue?");
        Console.WriteLine("1)yes");
        Console.WriteLine("2)no");
        int cont = int.Parse(Console.ReadLine());
        if (cont == 1) { 
        
            menu();

        }
        else
        {
         repeat = false;
        }

    }
    else if (ch == 2)
    {
        regester();
        Console.WriteLine("do you want to login? 1)yse 2)no");

        int choose = int.Parse(Console.ReadLine());
        if (choose == 1)
        {
            login();
            menu();
            Console.WriteLine("do u want to continue? 1)yes 2)no");
            int cho = int.Parse (Console.ReadLine());
            if (cho == 1)
            {
                menu();
            }
            else
            {
                User u = new User();
                Console.WriteLine(u.logout);
                repeat = false;
            }

        }

    }
}

void regester()
{
    Console.WriteLine("please enter your usename");
    string username = Console.ReadLine();
    Console.WriteLine("please enter your email");
    string email = Console.ReadLine();
    Console.WriteLine("please enter your password");
    string password = Console.ReadLine();
    User u1 = new User(username , email , password);
    Console.WriteLine(u1.Regester(username, email, password)); 
}
void login()
{
    
    Console.WriteLine("please enter your username");
    string username = Console.ReadLine();
    Console.WriteLine("please enter your password");
    string password = Console.ReadLine();
    User u1 = new User(username , password );
    Console.WriteLine(u1.Login(username, password)); 
}


void menu()
{
    
    Console.WriteLine("1)choose product");
    Console.WriteLine("2)see the cart");
 
    Console.WriteLine("3)log out");
    int menu = int.Parse(Console.ReadLine());
    switch (menu)
    {
        case 1:
            Console.WriteLine("choose category");
            Console.WriteLine("1)phone");
            Console.WriteLine("2)laptop");
            Console.WriteLine("3)accessories");
            int cat = int.Parse(Console.ReadLine());
            Product product = new Product();
            product.categoryList(cat);
            Console.WriteLine("do u want to buy?");
            Console.WriteLine("1)yes");
            Console.WriteLine("2) no");
            int buy = int.Parse(Console.ReadLine());
            if(buy == 1)
            {
                Console.WriteLine("enter product id");
                int productid = int.Parse(Console.ReadLine());
                User u = new User(productid);
                Console.WriteLine(u.AddToCart(productid));
                Console.WriteLine("do u want to see the cart? 1)yes 2)no");
                int yn = int.Parse(Console.ReadLine());
                if(yn == 1)
                {
                    Console.WriteLine("your cart is :");

                    u.SeeCart();
                    Console.WriteLine("do u want to confirm transaction? 1)yes 2)no(exie)");
                    int conf = int.Parse(Console.ReadLine());
                    if(conf == 1)
                    {
                        Console.WriteLine(u.Confirmation());
                    }
                    else
                    {
                        Console.WriteLine(u.logout);
                        repeat = false;
                    }
                    Console.WriteLine("do u want to see your last purchase? 1)yes 2)no");
                    conf = int.Parse( Console.ReadLine());
                    if( conf == 1)
                    {
                        u.LastOrder();
                    }

                }
            }
          
            break;
           
            
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class operation
    {
        int choice;

        item_list data;
        cart cart;

        public operation(item_list dt, cart cr)
        {
            data = dt;

            cart = cr;
        }

        public void add()
        {
            Console.Clear();

            data.show_data();

            Console.Write("Pick Your choice: ");

            choice = Int32.Parse(Console.ReadLine());

            int price = data.remove(choice);

            string s = data.get_name(choice);

            cart.addToCart(price,s);

        }

        public void remove()
        {
            Console.Clear();

            cart.show_cart();

            Console.Write("Which Item do you want to remove: ");

            choice = Int32.Parse(Console.ReadLine());

            cart.removeFromCart(choice);
            
        }

        public void view()
        {
            Console.Clear();

            Console.WriteLine("\nItems in your Cart are listed below\n");

            cart.show_cart();

            Console.WriteLine("\n\nPress any key to continue...");

            Console.ReadKey();

            Console.Clear();
        }

        public void checkout_pay()
        {
            Console.Clear();

            Console.WriteLine("\nItems in your Cart are listed below\n");

            cart.show_cart();

            Console.WriteLine("\n\nAre You sure you want to proceed with checkout? (y/n): ");

            string x= Console.ReadLine();

            if(x=="y" || x=="Y")
            {
                cart.checkout();
            }

            else if (x == "n" || x == "N")
            {
                return;
            }

            Console.Clear();
        }

        public void exit()
        {

        }
    }
}

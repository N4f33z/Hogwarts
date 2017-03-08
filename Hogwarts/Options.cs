using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hogwarts
{
    class Options
    {
        int choice;

        public Options(item_list data, cart list)
        {
            operation op = new operation(data,list);

            while(choice!=5)
            {
                

                choice = show_msg();

                if (choice == 1)
                    op.add();

                else if (choice == 2)
                    op.remove();

                else if (choice == 3)           //aa
                    op.view();

                else if (choice == 4)
                {
                    op.checkout_pay();
                    return;
                }
                    

                else if (choice == 5) return;
                    
            }
            
        }

        public int show_msg()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO THE SHOPPING CART!");
            Console.WriteLine("Following options are available to you:");
            Console.WriteLine("1. Add an item to cart");
            Console.WriteLine("2. Remove an item from the cart");
            Console.WriteLine("3. View the cart");
            Console.WriteLine("4. Checkout and Pay");
            Console.WriteLine("5. Exit");

            Console.Write("Your Choice: ");

            int inp = Int32.Parse(Console.ReadLine());  
            
            return inp;

        }

        
    }
}

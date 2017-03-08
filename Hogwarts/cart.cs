using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class cart
    {
        int total_price;

        static int count;
        
       public struct items
        {
            public int index, price;  //aa

            public string item;
        }

        items[] ob = new items[50];

        Dictionary<string, int> list;

        public cart()
        {
            total_price = 0;

            count = 1;

            list = new Dictionary<string, int>();

            for(int i=0;i<50;i++)
            {
                list[""] = 0;
            }
        }

        public void addToCart(int prc, string s)
        {
            

            total_price = total_price + prc;

            ob[count].price = prc;

            ob[count].index = count;

            ob[count].item = s;

            if (!list.ContainsKey(s))
            {
                list[s] = 0;

                count++;
            }
  
            list[s]++;

            

        }

        public void removeFromCart(int choice)
        {

            for(int i=choice; i<count;i++)
            {
                ob[i].item = ob[i+1].item;

                ob[i].price = ob[i+1].price;
            }

            count--;

        }

        public void show_cart()
        {
            Console.WriteLine("You have purchased the following item(s)\n");

            for (int i=1;i<count;i++)
            {
                string name = ob[i].item;

                int prc = ob[i].price;

                Console.WriteLine(ob[i].index + "|  " + name+" X "+list[name]+" |   Cost: "+prc* list[name]+ "  ( "+prc+" )\n\n");
            }
        }

        public void checkout()
        {
            Console.Clear();

            Console.WriteLine("You have purchased the following item(s)\n");

            show_cart();

            Console.WriteLine("Total Bill: " + total_price+" \n\n");

            Console.WriteLine("Thanks for Your purchase.. we hope to see you again :) \n");

            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }
    }
}

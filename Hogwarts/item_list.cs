using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class item_list
    {
        public struct items
        {
            public int index, available, price;

            public string item;
        }

        

        int item_count = 0;

        items[] ob = new items[50];

        public item_list()
        {

        }

        public void data_in(int x, int y, int z, string s, int cnt)
        {
            int i = cnt;

            ob[cnt].index = x;

            ob[cnt].available = y;

            ob[cnt].price = z;

            ob[cnt].item = s;

            item_count = cnt;
        }

        public void show_data()
        {
            //Console.WriteLine("  No.          Item Name           Price ");
            //Console.WriteLine("------       -------------       ---------");

            for (int i = 1; i <= item_count; i++)
            {
                Console.WriteLine(+ob[i].index + "|  " + ob[i].item + "|  " + ob[i].available + "|  " + ob[i].price + "\n");
            }

        }

        public int remove(int i)
        {
            ob[i].available--;

            return ob[i].price;
        }

        

        public string get_name(int choice)
        {
            return ob[choice].item;
        }
    }
}

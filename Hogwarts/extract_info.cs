using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class extract_info : get_file
    {
       

       public extract_info(string[] str,int sz)
        {

        }

        public item_list extract_obj(string[] str, int sz)
        {
            int count = 1, x = 0, k = 0, l = 0;

            string name = "";

            item_list data = new item_list();

            for (int temp = 0; temp < sz; temp++)
            {
                string s = str[temp];
                int i = 0;

                string[] result = s.Split(',');

                foreach (string ss in result)
                {
                    if (i > 3)
                        break;

                    if (i == 0)
                    {
                        x = Int32.Parse(ss);

                    }

                    else if (i == 1)
                    {
                        name = ss;

                    }

                    else if (i == 2)
                    {
                        k = Int32.Parse(ss);

                    }

                    else if (i == 3)
                    {
                        l = Int32.Parse(ss);
                    }

                    i++;

                }

                data.data_in(x, k, l, name, count);  //aa

                count++;

            }

            return data;
        }
    }
}

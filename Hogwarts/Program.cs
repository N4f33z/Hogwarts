using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            get_file ob = new get_file();
            
            string [] s= ob.show_file();

            int size = ob.input_sz();

            extract_info ob1 = new extract_info(s,size);

            item_list data= ob1.extract_obj(s,size);

            cart list = new cart();

            Options option = new Options(data,list);
            

            //Console.ReadKey();
        }
    }
}

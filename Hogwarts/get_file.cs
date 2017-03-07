using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{

    

    class get_file
    {
        string[] input = new string[100];

        public int inputSize; 

        public get_file()
        {
            string[] file = System.IO.File.ReadAllLines(@"E:\product.inventory.txt");

            int i = 0;

            foreach (string line in file)
            {
                input[i] = line;

                i++;
            }

            inputSize = i;

            
        }

        public string[] show_file()
        {
            //for(int i=0; i<= inputSize; i++)
            //{
            //    Console.WriteLine(input[i]);
            //}

            //Console.ReadKey();

            return input;
        }

        public int input_sz()
        {
            return inputSize;
        }
        
    }
}

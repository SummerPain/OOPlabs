using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ooplab7
{
    static class GYMController
    {
        public static void Item_On_Price_Range(int min, int max, GYM gym)
        {
            int i = 0;
            while (gym[i + 1] != null)
            {
                if (gym[i].Price >= min && gym[i].Price <= max)
                {
                    Console.WriteLine(gym[i]);
                }
                i++;
            }
        }
        public static void Read_from_file(ref GYM gym)
        {
            string path = "info.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                int j = 0;
                int price = 0;
                int quantity = 0;
                int space = 0;
                string form = "";
                string from_file;
                for (int i = 0; gym.MaxIndex > i; i++)
                {

                    while ((from_file = sr.ReadLine()) != null)
                    {

                        if (j == 0)
                        {
                            price = Convert.ToInt32(from_file);
                        }
                        if (j == 1)
                        {
                            quantity = Convert.ToInt32(from_file);
                        }
                        if (j == 2)
                        {
                            form = from_file;
                        }
                        if (j == 3)
                        {
                            space = Convert.ToInt32(from_file);
                            j = 0;
                            break;
                        }
                        j++;
                    }
                    gym[i] = new Mats(quantity, price, form, space);
                }

            }
        }
    }
}

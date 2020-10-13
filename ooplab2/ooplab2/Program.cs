using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.a
            bool type1 = true;
            byte type2 = 7; //0-255
            sbyte type3 = 13; //-127 - 127
            char type4 = 'a';
            decimal type5 = 3.535233576454m;
            double type6 = 155.72;
            float type7 = 4756.74183f;
            int type8 = -124;    //-2147483648 - 2147483647
            uint type9 = 349;   //0 - 4294967295
            long type10 = -715208423597;
            ulong type11 = 567356479;
            short type12 = -11132;
            ushort type13 = 5746;
            object type14 = new object();
            string type15 = "string type";
            dynamic type16;

            //1.b
            //явное преоброзование 
            double a0 = 2.3;
            int b0;
            b0 = (int)a0;
            //неявное
            int a1 = 4444;
            long b1 = a1;

            byte a2 = 255;
            ushort b2 = a2;

            uint a3 = 911;
            ulong b3 = a3;

            sbyte a4 = -127;
            short b4 = a4;

            //1.c
            int topack = 10;
            //
            //упаковка
            object pack = topack;
            //распаковка
            int tounpack = (int)pack;
        }
    }
}

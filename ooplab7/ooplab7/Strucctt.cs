using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    struct Prikol
    {
        public string funny_prikol;
        public string not_funny_prikol;
        public Prikol(string funny_prikol, string not_funny_prikol)
        {
            this.funny_prikol = funny_prikol;
            this.not_funny_prikol = not_funny_prikol;
        }
        public void info()
        {
            Console.WriteLine(funny_prikol + " " + not_funny_prikol);
        }
    }
}

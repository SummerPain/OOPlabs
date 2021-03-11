using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    public class LengthOfBenchException : Exception //исключение длины скамейки
    {
        public LengthOfBenchException(string msg) : base(msg) { }
    }
    public class PriceOfBallException : Exception //исключение цены мяча
    {
        public PriceOfBallException(string msg) : base(msg) { }
    }
    public class CountOfRacketInTennisException : Exception //исключение количества ракеток в теннисе
    {
        public CountOfRacketInTennisException(string msg) : base(msg) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    class Generate
    {
        private int _number;
        public Generate()
        {
            Random number = new Random();
            _number = number.Next(0, 101);
        }
        public int GetNumber()
        {
            return _number;
        }
    }
}

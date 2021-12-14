using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    public class Game
    {
        private int _number;
        public Game(int number)
        {
            _number = number;
        }
        public Output Check(int userInput)
        {
            if (userInput  < _number)
            {
                return new Output("greater", false);
            }
            else if (userInput > _number)
            {
                return new Output("less", false);
            }
            else if (userInput == _number)
            {
                return new Output("true" , true);
            }
            return new Output("error", false);
        }
    }
}

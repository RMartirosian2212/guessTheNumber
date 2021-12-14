using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    public class Output
    {
        private string _message;
        private bool _isOver;
        public Output(string message, bool isOver)
        {
            _message = message;
            _isOver = isOver;
        }
        public string Message()
        {
            return $"Current number is {_message}";
        }
        public bool IsOver()
        {
            return _isOver;
        }
    }
}

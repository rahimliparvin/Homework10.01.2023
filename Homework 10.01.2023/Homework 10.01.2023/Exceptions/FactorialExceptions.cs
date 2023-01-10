using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10._01._2023.Exceptions
{
    public class FactorialExceptions : Exception
    {
        public FactorialExceptions(string message) :base(message) { }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCore.Exceptions
{
    public class DrawException: Exception
    {
        public DrawException(string message) : base(message)
        {
              
        }
    }
}

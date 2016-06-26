using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System.Classes
{
    class CustomExceptions: Exception
    {
        public CustomExceptions(String msg)
            : base(msg)
        { 
        
        }
    }
}

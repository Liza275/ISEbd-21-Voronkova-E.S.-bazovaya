using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirportAlreadyHaveException: Exception
    {
        public AirportAlreadyHaveException() : base("В аэропорту уже есть такой самолет")
        {
        }
    }    
}

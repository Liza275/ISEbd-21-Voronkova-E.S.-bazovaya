using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{

    public class AirportNotFoundException : Exception
    {
        public AirportNotFoundException(int i) : base("Не найден самолет по месту " + i)
        {

        }
    }
}

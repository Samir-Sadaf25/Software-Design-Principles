using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class VictorianSofa : ISofa
    {
        public void lieOn()
        {
            Console.WriteLine("lie on victorian sofa");
        }
    }
}

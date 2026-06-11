using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class ModernChair : IChair
    {
        public void sitOn()
        {
            Console.WriteLine("sit on modern chair");
        }
    }
}

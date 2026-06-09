using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation_Principle
{
    public class Report
    {
        public void Show(Order order)
        {
            Console.WriteLine($"price : {order.total}");
        }
    }
}

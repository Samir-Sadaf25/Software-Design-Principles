using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favor_Composition_Over_Inheritance
{
    public class SlackManegar : Employee
    {
        public override void SendNotification()
        {
            Console.WriteLine("Sending message to slack"); //changes are not developer..but notification system
        }
    }
}

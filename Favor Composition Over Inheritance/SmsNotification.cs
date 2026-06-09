using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favor_Composition_Over_Inheritance
{
    public class SmsNotification : ISendNotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"send notification on phone message {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulate_what_varies
{
    public interface IPayementMethod
    {
        public void Pay(decimal amount);
    }
}

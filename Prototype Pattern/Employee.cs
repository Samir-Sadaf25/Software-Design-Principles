using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class Employee
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }

       public Employee Clone()
        {
            return new Employee
            {
                Name = this.Name,
                Skills = this.Skills
            };
        }
    }
}

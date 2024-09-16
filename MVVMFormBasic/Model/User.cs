using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFormBasic.Model
{
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name + ", " + this.Age + " years old";
        }
    }
}

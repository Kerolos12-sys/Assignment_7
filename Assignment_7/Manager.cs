using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing");
            base.Work();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementVariants
{
    class FlyMovement:Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}

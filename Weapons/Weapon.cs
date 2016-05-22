using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    /// <summary>
    /// abstract class 
    /// </summary>
    public abstract class Weapon
    {
        public int PAtack { get; protected set; }
        public int MAtack { get; protected set; }
        public string Grade { get; protected set; }

        public abstract void Hit();
    }
}

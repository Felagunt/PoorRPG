using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// base race
/// </summary>
namespace KindOfRaces
{
    abstract class Race
    {
        public int Hp { get; protected set; }
        public int Int { get; protected set; }
        public int Wit { get; protected set; }
        public int Dex { get; protected set; }
        public int Men { get; protected set; }
        public int Str { get; protected set; }
        public int Mp { get; protected set; }
        const int lvl= 1;

        public void HitPoints()
        {
            Hp = Str * lvl;
        }
        public void MagicPoints()
        {
            Mp = Men * lvl;
        }
    }
}

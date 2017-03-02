using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.DBModel
{
    [Flags]
    public enum Extras
    {
        Noball = 1,
        LegBye = 2,
        Bye = 4,
        Wide = 8,
        OverThrow = 16 
    }

    public enum OutType
    {
        Bowled = 1,
        Runout,
        LBW,
        Caught,
        Hitwicket,
        Stumped,
        Retired
    }

    public enum Runs
    {
        Single = 1,
        Two,
        Three,
        Boundary,
        Five,
        Six
    }
}

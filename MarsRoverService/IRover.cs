using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverService
{
    public interface IRover
    {
        IPosition RoverPosition { get; set; }
        Direction RoverDirection { get; set; }
        PositionLimit RoverPositionLimit { get; set; }       
        void Operate(string commands);
        string ToString();
    }
}

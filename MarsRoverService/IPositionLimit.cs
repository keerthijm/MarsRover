using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverService
{
    public interface IPositionLimit
    {
        Position PositionLimitCoordinates { get; }
    }
}

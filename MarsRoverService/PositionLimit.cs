using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverService
{
    public class PositionLimit : IPositionLimit
    {
        public Position PositionLimitCoordinates { get; private set; }

        public PositionLimit(Position position)
        {
            PositionLimitCoordinates = position;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverService
{
    public class Rover : IRover
    {
        public IPosition RoverPosition
        {
            get;
            set;
        }
        public Direction RoverDirection
        {
            get;
            set;
        }
        public PositionLimit RoverPositionLimit { get; set; }       

        public Rover(IPosition roverPosition, Direction roverDirection, PositionLimit roverPositionLimit)
        {
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
            RoverPositionLimit = roverPositionLimit;
        }

        public void Operate(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('F'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }

        private void TurnLeft()
        {
            RoverDirection = (RoverDirection - 1) < Direction.N ? Direction.W : RoverDirection - 1;
        }

        private void TurnRight()
        {
            RoverDirection = (RoverDirection + 1) > Direction.W ? Direction.N : RoverDirection + 1;
        }

        private void Move()
        {
            if (RoverDirection == Direction.N)
            {
                RoverPosition.Y++;
            }
            else if (RoverDirection == Direction.E)
            {
                RoverPosition.X++;
            }
            else if (RoverDirection == Direction.S)
            {
                RoverPosition.Y--;
            }
            else if (RoverDirection == Direction.W)
            {
                RoverPosition.X--;
            }
        }

        public override string ToString()
        {          
            return string.Format("Rover current position : {0} {1} {2}", RoverPosition.X, RoverPosition.Y, RoverDirection.ToString());
        }
    }
}

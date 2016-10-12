using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverService;

namespace MarsRoverServiceTest
{
    [TestClass]
    public class MarsRoverTest
    {
        private IRover _roverOne = null;
        private void SetupRover()
        {
            _roverOne = new Rover(new Position(0, 0), Direction.N, new PositionLimit(new Position(5, 5)));
        }

        [TestMethod]
        public void Move_Rover_Check_Output1()
        {
            //Initialize rover
            SetupRover();
            //Send command to rover
            _roverOne.Operate("RFFFLFLFRFFFRFLF");          
            Assert.AreEqual(_roverOne.RoverPosition.X, 3);
            Assert.AreEqual(_roverOne.RoverPosition.Y, 5);
            Assert.AreEqual(_roverOne.RoverDirection.ToString(), "N");
        }

        [TestMethod]
        public void Move_Rover_Check_Output2()
        {
            //Initialize rover
            SetupRover();
            //Send command to rover
            _roverOne.Operate("RFLFLFLFL");
            Assert.AreEqual(_roverOne.RoverPosition.X, 0);
            Assert.AreEqual(_roverOne.RoverPosition.Y, 0);
            Assert.AreEqual(_roverOne.RoverDirection.ToString(), "E");
        }
    }
}

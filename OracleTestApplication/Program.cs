using MarsRoverService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mars Rover Test Application");
            Console.WriteLine("Landscape initialized to 5x5 Grid.");           
            //Initializing the first rover with the rover position, the rover orientation and the plateau limit;
            Rover roverOne = new Rover(new Position(0, 0), Direction.N, new PositionLimit(new Position(5, 5)));
            Console.WriteLine("The Rover initial position : 0 0 N");
            Console.WriteLine("Command to rover : RFLFFRF");
            roverOne.Operate("RFLFFRF");         
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Output: Grid position of the Rover after those commands");
            Console.WriteLine(roverOne.ToString());
            Console.ReadLine();
        }
    }
}

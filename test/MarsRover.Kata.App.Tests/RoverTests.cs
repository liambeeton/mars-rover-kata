using Xunit;

namespace MarsRover.Kata.App.Tests
{
    public class RoverTests
    {
        private readonly Rover _rover;

        public RoverTests()
        {
            _rover = new Rover();
        }

        [Theory]
        [InlineData("R", "0 0 E")]
        [InlineData("RR", "0 0 S")]
        [InlineData("RRR", "0 0 W")]
        [InlineData("RRRR", "0 0 N")]
        public void RotateRight_Orientation_Calculated(string commands, string position)
        {
            Assert.Equal(position, _rover.Execute(commands));
        }

        [Theory]
        [InlineData("L", "0 0 W")]
        [InlineData("LL", "0 0 S")]
        [InlineData("LLL", "0 0 E")]
        [InlineData("LLLL", "0 0 N")]
        public void RotateLeft_Orientation_Calculated(string commands, string position)
        {
            Assert.Equal(position, _rover.Execute(commands));
        }
    }
}

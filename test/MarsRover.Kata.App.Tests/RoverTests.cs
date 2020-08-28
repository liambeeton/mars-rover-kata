using Xunit;

namespace MarsRover.Kata.App.Tests
{
    public class RoverTests
    {
        private readonly Grid grid;
        private readonly Rover rover;

        public RoverTests()
        {
            grid = new Grid(10, 10);
            rover = new Rover(grid);
        }

        [Theory]
        [InlineData("R", "0 0 E")]
        [InlineData("RR", "0 0 S")]
        [InlineData("RRR", "0 0 W")]
        [InlineData("RRRR", "0 0 N")]
        public void RotateRight_Orientation_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("L", "0 0 W")]
        [InlineData("LL", "0 0 S")]
        [InlineData("LLL", "0 0 E")]
        [InlineData("LLLL", "0 0 N")]
        public void RotateLeft_Orientation_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("M", "0 1 N")]
        [InlineData("MMM", "0 3 N")]
        public void MoveUp_Position_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("MMMMMMMMMM", "0 0 N")]
        [InlineData("MMMMMMMMMMMMMMM", "0 5 N")]
        public void MoveUp_WrapTopToBottom_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("RM", "1 0 E")]
        [InlineData("RMMMMM", "5 0 E")]
        public void MoveRight_Position_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("RMMMMMMMMMM", "0 0 E")]
        [InlineData("RMMMMMMMMMMMMMMM", "5 0 E")]
        public void MoveRight_WrapLeftToRight_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("LM", "9 0 W")]
        [InlineData("LMMMMM", "5 0 W")]
        public void MoveLeft_Position_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }

        [Theory]
        [InlineData("LLM", "0 9 S")]
        [InlineData("LLMMMMM", "0 5 S")]
        public void MoveDown_Position_Calculated(string commands, string position)
        {
            Assert.Equal(position, rover.Execute(commands));
        }
    }
}

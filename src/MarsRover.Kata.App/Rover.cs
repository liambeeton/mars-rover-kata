
namespace MarsRover.Kata.App
{
    public class Rover
    {
        private Direction direction = new Direction("N", "W", "E");
        private Coordinate coordinate = new Coordinate(0, 0);
        private readonly Grid grid;

        public Rover(Grid grid)
        {
            this.grid = grid;
        }

        public string Execute(string commands)
        {
            foreach (char command in commands)
            {
                if (command == 'R')
                {
                    direction = direction.Right();
                }
                if (command == 'L')
                {
                    direction = direction.Left();
                }
                if (command == 'M')
                {
                    coordinate = grid.Next(coordinate, direction);
                }
            }
            return $"{coordinate.X} {coordinate.Y} {direction.Value()}";
        }
    }
}
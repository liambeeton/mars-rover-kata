
namespace MarsRover.Kata.App
{
    public class Rover
    {
        private Direction direction;
        private Coordinate coordinate;
        private readonly Grid grid;

        public Rover(Grid grid, Direction direction, Coordinate coordinate)
        {
            this.grid = grid;
            this.direction = direction;
            this.coordinate = coordinate;
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
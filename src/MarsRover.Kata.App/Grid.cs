namespace MarsRover.Kata.App
{
    public class Grid
    {
        private readonly int height;
        private readonly int width;

        public Grid(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public Coordinate Next(Coordinate coordinate, Direction direction)
        {
            int x = coordinate.X;
            int y = coordinate.Y;
            if (direction.Value() == Direction.North.Value())
            {
                y = (y + 1) % height;
            }
            if (direction.Value() == Direction.East.Value())
            {
                x = (x + 1) % width;
            }
            if (direction.Value() == Direction.South.Value())
            {
                y = (y > 0) ? y - 1 : height - 1;
            }
            if (direction.Value() == Direction.West.Value())
            {
                x = (x > 0) ? x - 1 : width - 1;
            }
            return new Coordinate(x, y);
        }
    }
}

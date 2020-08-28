using System.Collections.Generic;

namespace MarsRover.Kata.App
{
    public class Direction
    {
        public static Direction North = new Direction("N", "W", "E");
        public static Direction East = new Direction("E", "N", "S");
        public static Direction South = new Direction("S", "E", "W");
        public static Direction West = new Direction("W", "S", "N");

        private readonly string value;
        private readonly string left;
        private readonly string right;

        public Direction(string value, string left, string right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public static IEnumerable<Direction> Values 
        {
            get 
            {
                yield return North;
                yield return East;
                yield return South;
                yield return West;
            }
        }

        public Direction Right()
        {
            return Heading(right);
        }

        public Direction Left()
        {
            return Heading(left);
        }

        public string Value()
        {
            return value;
        }

        private Direction Heading(string value)
        {
            foreach (Direction direction in Values)
            {
                if (direction.Value() == value)
                {
                    return direction;
                }
            }
            return null;
        }
    }
}
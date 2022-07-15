namespace GetNeighbors
{
    /// <summary>
    /// Represents a point on the coordinate plane.
    /// </summary>
    public readonly struct Point : System.IEquatable<Point>
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }

        public int Y { get; }
        
        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }
        
        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
        
        public override int GetHashCode()
        {
            return this.X.GetHashCode() ^ this.Y.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (!(obj is Point))
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Point point = (Point)obj;
            
            return this.Equals(point);
        }

        public bool Equals(Point other)
        {
            return this.X == other.X && this.Y == other.Y;
        }
    }
}

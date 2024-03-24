namespace Events
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point3D other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            double dz = Z - other.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }

    public class Program
    {
        static void Main()
        {
            Point3D[] points = new Point3D[]
            {
                new Point3D(0, 0, 0),
                new Point3D(1, 1, 1),
                new Point3D(2, 3, 4),
                new Point3D(-1, -2, 1)
            };

            double maxDistance = 0;
            Point3D? pointA = null;
            Point3D? pointB = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        pointA = points[i];
                        pointB = points[j];
                    }
                }
            }

            Console.WriteLine("The two points that are farthest apart are:");
            Console.WriteLine($"({pointA.X}, {pointA.Y}, {pointA.Z})");
            Console.WriteLine($"({pointB.X}, {pointB.Y}, {pointB.Z})");
            Console.WriteLine($"The distance between them is {maxDistance}");
        }
    }
}

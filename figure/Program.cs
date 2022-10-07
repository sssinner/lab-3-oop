namespace Figure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[]
            {
                new Point(2, 4, "A"),
                new Point(1, -4, "B"),
                new Point(-1, -4, "C"),
                new Point(3, 5, "D"),
            };

            Figure figure = new Figure(points);
            figure.PerimeterCalculator();
        }
    }
}
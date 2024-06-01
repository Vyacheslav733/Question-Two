namespace ShapesLibrary
{
	public class ShapeFactory
	{
		public static IShape CreateCircle(double r)
		{
			return new Circle(r);
		}

		public static IShape CreateTriangle(double a, double b, double c)
		{
			return new Triangle(a, b, c);
		}
	}
}

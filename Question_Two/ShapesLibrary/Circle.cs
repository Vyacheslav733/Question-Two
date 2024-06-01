namespace ShapesLibrary
{
	public class Circle : IShape
	{
		public double R { get; }

		public Circle(double r)
		{
			R = r;
		}

		public double CalcArea()
		{
			return Math.PI * R * R;
		}
	}
}

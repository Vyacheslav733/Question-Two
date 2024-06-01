namespace ShapesLibrary
{
	public class Triangle : IShape
	{
		public double A { get; }
		public double B { get; }
		public double C { get; }

		public Triangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;

			if (!IsValidTriangle())
			{
				throw new ArgumentException("Недопустимые стороны треугольника");
			}
		}

		public double CalcArea()
		{
			double s = (A + B + C) / 2;
			return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
		}

		public bool IsRightTriangle()
		{
			double[] sides = new double[] { A, B, C };
			Array.Sort(sides);
			// 1e-10 - проверяем погрешность с точностью до 10^(-10)
			return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
		}

		private bool IsValidTriangle()
		{
			return A + B > C && A + C > B && B + C > A;
		}
	}
}

namespace ShapesLibrary.Tests
{
	public class ShapeTests
	{
		[Fact]
		public void TestCircleArea()
		{
			IShape circle = ShapeFactory.CreateCircle(10);
			Assert.Equal(Math.PI * 100, circle.CalcArea(), 10);
		}

		[Fact]
		public void TestTriangleArea()
		{
			IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
			Assert.Equal(6, triangle.CalcArea(), 10);
		}

		[Fact]
		public void TestInvalidTriangle()
		{
			Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(1, 1, 2));
		}

		[Fact]
		public void TestRightTriangle()
		{
			Triangle triangle = new Triangle(3, 4, 5);
			Assert.True(triangle.IsRightTriangle());
		}

		[Fact]
		public void TestNonRightTriangle()
		{
			Triangle triangle = new Triangle(3, 4, 6);
			Assert.False(triangle.IsRightTriangle());
		}
	}
}
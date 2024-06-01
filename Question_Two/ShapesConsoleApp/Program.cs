using ShapesLibrary;

class Program
{
	static void Main()
	{
		IShape circle = ShapeFactory.CreateCircle(5);
		Console.WriteLine($"Площадь круга: {circle.CalcArea()}");

		IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
		Console.WriteLine($"Площадь треугольника: {triangle.CalcArea()}");

		Triangle specificTriangle = (Triangle)triangle;
		Console.WriteLine($"Представляет собой прямоугольный треугольник: {specificTriangle.IsRightTriangle()}");
	}
}

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape rectangle = shapeFactory.GetShape("rectangle");
            rectangle.Draw();

            IShape circle = shapeFactory.GetShape("circle");
            circle.Draw();

            IShape square = shapeFactory.GetShape("square");
            square.Draw();
        }
    }
}
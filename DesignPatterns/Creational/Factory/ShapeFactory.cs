namespace Factory
{
    internal class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            if(type.ToLower() == "rectangle")
                return new Rectangle();
            else if (type.ToLower() == "circle")
                return new Circle();
            else if (type.ToLower() == "square")
                return new Square();
            return null;
        }
    }
}

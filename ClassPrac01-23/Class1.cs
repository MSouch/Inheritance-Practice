namespace InheritanceDemo01F 
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius { get; set; }
        public Circle() : base("red", false)
        {
            Radius = 10;
        }

        public Circle(double radius) : base("red", false)
        {
            this.radius = Radius;
        }

        public override double CalculatePerameter()
        {
            return double.Pi * this.radius;
        }

        public override double CalculateArea()
        {
            return double.Pi * this.Radius * this.Radius;
        }
        public override string ToString()
        {
            return $"details of the circle are {CalculateArea} and {CalculatePerameter}";
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing {color} shape with {IsFilled} filling");
        }
    }
}

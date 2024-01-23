namespace InheritanceDemo01F
{

    public class Shape
    {
        protected string color { get; set; }
        protected bool IsFilled { get; set; }

        public Shape()
        {
            this.color = "red";
            this.IsFilled = false;

        }
        public Shape(string color, bool isFilled)
        {
            this.color = color;
            this.IsFilled = isFilled;

        }
        public virtual void ChangeColor(string c)
        {
            this.color = c;
        }
        public virtual double CalculateArea()
        {
            return 0.0;
        }
        public virtual double CalculatePerameter()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"Details of the shape \n" +
                $"color {color}" +
                $"filling {IsFilled}";
        }

    }
}
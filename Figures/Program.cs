using Figures;
class Program
{
    static void Main(string[] args)
    {
        Rectangle building1 = new Rectangle(10, 4);

        Triangle roof1 = new Triangle(5, 8, 25);

        Circle road1 = new Circle(34);

        Calculator calc1 = new Calculator();
        calc1.FigureArea(building1);
    }
}

interface IFigure
{
    double CalculatePerimeter();
    double CalculateArea();
}

class Calculator
{
    public double FigureArea(IFigure figure)
    {
        return figure.CalculateArea();
    }

    public double FigurePerimeter(IFigure figure)
    {
        return figure.CalculatePerimeter();
    }
}

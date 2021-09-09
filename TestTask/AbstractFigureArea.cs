using System;

namespace TestTask
{
    public abstract class AbstractFigureArea
    {
        private readonly Lazy<double> _area;
        public double Area { get { return _area.Value; } }
        public abstract double CalculateArea();

        protected AbstractFigureArea()
        {
            _area = new Lazy<double>(CalculateArea); //Этот конструктор вызывается в начале работы конструкторов дочерних типов, в которых инициализируется Radius, поэтому здесь нужен Lazy<>
        }
    }
}

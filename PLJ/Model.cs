
using System.Drawing.Drawing2D;

namespace PLJ
{
    public class Model
    {
        bool[,] _matrix;
        private int _stepCounter = 0;
        public bool _win;
        private readonly double _expectedNeighbourDistance;
        readonly View _myView; 

        public Model(double expectedNeighbourDistance, View view) 
        {
            _expectedNeighbourDistance = expectedNeighbourDistance;
            _matrix = new bool[5, 5];
            _myView = view;
        }

        private void IncreaseStepCounter()
        {
            _stepCounter++;
        }

        public void Step(Point coordinates) 
        {
            IncreaseStepCounter();
            
            bool everythingOk = true;

            _matrix[coordinates.X, coordinates.Y] = !_matrix[coordinates.X, coordinates.Y];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    double distance = GetDistance(coordinates, new(i,j));
                    
                    if (EqualsWithTolerance(distance, _expectedNeighbourDistance, 0.001))
                        _matrix[i, j] = !_matrix[i, j];

                    if (!_matrix[i, j])
                        everythingOk = false;
                }
            }
            if (everythingOk)
            {
                _win = true;
            }

            _myView.ShowModel(_matrix, _win, _stepCounter);
        }

        private double GetDistance(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2));
        }

        private bool EqualsWithTolerance(double actual, double expectedDistance, double tolerance)
        {
            return Math.Abs(actual - expectedDistance) < tolerance;
        }

        internal void Init()
        {
            _myView.SetUp(_matrix);
        }
    }
}

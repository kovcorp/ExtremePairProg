
namespace PLJ
{
    public class Controller
    {
        readonly Model _myModel; 

        public Controller(Model myModel) 
        {
            _myModel = myModel;
        }

        public void RedirectClickToModel(Point matrixCoordinate)
        {
            _myModel.Step(matrixCoordinate);
        }

        public void Init() 
        {
            _myModel.Init();
        }
    }
}

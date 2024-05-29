using KamienPapierNozyce_App.Services.Abstraction;

namespace KamienPapierNozyce_App.Services
{
    public class PointCounterService : IPointCounterService
    {
        private int _theirPoints;
        private int _myPoints;

        public PointCounterService()
        {
            _theirPoints = _myPoints = 0;
        }
        public int GetMyPoints() => _myPoints;
        public int GetTheirPoints() 
        {
            return _theirPoints;
        }
        public int AddMyPoints()
        {
            return _myPoints += 1;
        }
        public int AddTheirPoints()
        {
            return _theirPoints += 1;
        }
        public void PointsClear()
        {
            _theirPoints = _myPoints = 0;
        }
    }
}

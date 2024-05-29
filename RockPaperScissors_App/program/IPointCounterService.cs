namespace KamienPapierNozyce_App.Services.Abstraction
{
    public interface IPointCounterService
    {
        public int GetMyPoints();
        public int GetTheirPoints();

        public int AddMyPoints();

        public int AddTheirPoints();
        public void PointsClear();       

    }
}

using KamienPapierNozyce_App.Services.Abstraction;
using KamienPapierNozyce_Console;

namespace KamienPapierNozyce_App
{
    public partial class Game : Form
    {

        private readonly IPointCounterService _pointCounterService;
        public Game(IPointCounterService pointCounterService)
        {
            this._pointCounterService = pointCounterService;
            InitializeComponent();
        }
        private static int ButtonData(int itemNumber)
        {
            return GameMechanics.Fight(GameMechanics.MyItem(), itemNumber);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            lblDraw.Hide();
            lblWin.Hide();
            lblLose.Hide();

            ResultMessageShow(ButtonData(1));
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            lblDraw.Hide();
            lblWin.Hide();
            lblLose.Hide();

            ResultMessageShow(ButtonData(2));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            lblDraw.Hide();
            lblWin.Hide();
            lblLose.Hide();

            ResultMessageShow(ButtonData(3));
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            SummaryPanel.Show();
            GamePanel.Hide();
            myPointsLbl.Text = _pointCounterService.GetMyPoints().ToString();
            theirPointsLbl.Text = _pointCounterService.GetTheirPoints().ToString();
            if (_pointCounterService.GetTheirPoints() > _pointCounterService.GetMyPoints()) lblWinGame.Show();
            else if (_pointCounterService.GetTheirPoints() < _pointCounterService.GetMyPoints()) lblLoseGame.Show();
            else if (_pointCounterService.GetTheirPoints() == _pointCounterService.GetMyPoints()) lblDrawGame.Show();
        }
        private void btnAgain_Click(object sender, EventArgs e)
        {
            _pointCounterService.PointsClear();
            lblDraw.Hide();
            lblWin.Hide();
            lblLose.Hide();
            lblLoseGame.Hide();
            lblDrawGame.Hide();
            lblWinGame.Hide();
            GamePanel.Show();
            SummaryPanel.Hide();
        }
        private void ResultMessageShow(int result)
        {
            switch (result)
            {
                case 1:
                    _pointCounterService.AddTheirPoints();
                    lblWin.Show();
                    break;
                case 2:
                    _pointCounterService.AddMyPoints();
                    lblLose.Show();
                    break;
                case 3:
                    lblDraw.Show();
                    break;
            }
        }
    }
}

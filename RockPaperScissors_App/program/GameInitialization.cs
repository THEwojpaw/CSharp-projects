using KamienPapierNozyce_App.Services.Abstraction;

namespace KamienPapierNozyce_App
{
    public partial class GameInitialization : Form
    {
        private readonly IPointCounterService _pointCounterService;
        private Game game;

        public GameInitialization(IPointCounterService pointCounterService)
        {
            this._pointCounterService = pointCounterService;
            InitializeComponent();
            game = new Game(_pointCounterService);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblRules.Show();
            btnTAK.Hide();
            btnNIE.Hide();
            btnContinue.Show();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            GameInitializationPanel.Show();
            StartPanel.Hide();
        }
    }
}

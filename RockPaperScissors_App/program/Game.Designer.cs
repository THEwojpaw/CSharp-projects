using KamienPapierNozyce_App.Services;

namespace KamienPapierNozyce_App
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            lblChooseItemStatement = new Label();
            btnScissors = new Button();
            btnPaper = new Button();
            btnStone = new Button();
            btnEndGame = new Button();
            lblWin = new Label();
            lblDraw = new Label();
            lblLose = new Label();
            lblPlayAnotherRoundStatement = new Label();
            GamePanel = new Panel();
            SummaryPanel = new Panel();
            theirPointsLbl = new Label();
            myPointsLbl = new Label();
            lblMyPoints = new Label();
            lblTheirPoints = new Label();
            lblGameResultsStatement = new Label();
            lblLoseGame = new Label();
            btnPlayAgain = new Button();
            lblDrawGame = new Label();
            lblWinGame = new Label();
            GamePanel.SuspendLayout();
            SummaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblChooseItemStatement
            // 
            lblChooseItemStatement.AutoSize = true;
            lblChooseItemStatement.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblChooseItemStatement.Location = new Point(286, 20);
            lblChooseItemStatement.Name = "lblChooseItemStatement";
            lblChooseItemStatement.Size = new Size(233, 28);
            lblChooseItemStatement.TabIndex = 0;
            lblChooseItemStatement.Text = "Wybierz swój przedmiot";
            // 
            // btnScissors
            // 
            btnScissors.Image = (Image)resources.GetObject("btnScissors.Image");
            btnScissors.Location = new Point(276, 66);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(262, 140);
            btnScissors.TabIndex = 2;
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += Button2_Click;
            // 
            // btnPaper
            // 
            btnPaper.Image = (Image)resources.GetObject("btnPaper.Image");
            btnPaper.Location = new Point(561, 66);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(196, 140);
            btnPaper.TabIndex = 3;
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += Button3_Click;
            // 
            // btnStone
            // 
            btnStone.Image = (Image)resources.GetObject("btnStone.Image");
            btnStone.Location = new Point(13, 65);
            btnStone.Name = "btnStone";
            btnStone.Size = new Size(230, 140);
            btnStone.TabIndex = 1;
            btnStone.UseVisualStyleBackColor = true;
            btnStone.Click += Button1_Click;
            // 
            // btnEndGame
            // 
            btnEndGame.BackColor = Color.Salmon;
            btnEndGame.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEndGame.Location = new Point(618, 372);
            btnEndGame.Name = "btnEndGame";
            btnEndGame.Size = new Size(158, 40);
            btnEndGame.TabIndex = 7;
            btnEndGame.Text = "Zakończ rozgrywkę";
            btnEndGame.UseVisualStyleBackColor = false;
            btnEndGame.Click += Button4_Click;
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.BackColor = Color.YellowGreen;
            lblWin.BorderStyle = BorderStyle.Fixed3D;
            lblWin.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblWin.Location = new Point(268, 266);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(270, 43);
            lblWin.TabIndex = 8;
            lblWin.Text = "Zdobywasz punkt!";
            lblWin.Visible = false;
            // 
            // lblDraw
            // 
            lblDraw.AutoSize = true;
            lblDraw.BackColor = Color.PaleTurquoise;
            lblDraw.BorderStyle = BorderStyle.Fixed3D;
            lblDraw.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblDraw.Location = new Point(338, 266);
            lblDraw.Name = "lblDraw";
            lblDraw.Size = new Size(111, 43);
            lblDraw.TabIndex = 9;
            lblDraw.Text = "Remis.";
            lblDraw.Visible = false;
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.BackColor = Color.SandyBrown;
            lblLose.BorderStyle = BorderStyle.Fixed3D;
            lblLose.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblLose.Location = new Point(282, 266);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(237, 43);
            lblLose.TabIndex = 10;
            lblLose.Text = "Punkt dla mnie.";
            lblLose.Visible = false;
            // 
            // lblPlayAnotherRoundStatement
            // 
            lblPlayAnotherRoundStatement.AutoSize = true;
            lblPlayAnotherRoundStatement.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayAnotherRoundStatement.Location = new Point(100, 333);
            lblPlayAnotherRoundStatement.Name = "lblPlayAnotherRoundStatement";
            lblPlayAnotherRoundStatement.Size = new Size(618, 24);
            lblPlayAnotherRoundStatement.TabIndex = 11;
            lblPlayAnotherRoundStatement.Text = "Aby zagrać ponownie, ponownie wciśnij przycisk jednego z przedmiotów.";
            // 
            // GamePanel
            // 
            GamePanel.Controls.Add(btnStone);
            GamePanel.Controls.Add(lblChooseItemStatement);
            GamePanel.Controls.Add(btnEndGame);
            GamePanel.Controls.Add(lblPlayAnotherRoundStatement);
            GamePanel.Controls.Add(btnScissors);
            GamePanel.Controls.Add(lblWin);
            GamePanel.Controls.Add(lblDraw);
            GamePanel.Controls.Add(lblLose);
            GamePanel.Controls.Add(btnPaper);
            GamePanel.Location = new Point(12, 12);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(776, 415);
            GamePanel.TabIndex = 12;
            // 
            // SummaryPanel
            // 
            SummaryPanel.Controls.Add(theirPointsLbl);
            SummaryPanel.Controls.Add(myPointsLbl);
            SummaryPanel.Controls.Add(lblMyPoints);
            SummaryPanel.Controls.Add(lblTheirPoints);
            SummaryPanel.Controls.Add(lblGameResultsStatement);
            SummaryPanel.Controls.Add(lblLoseGame);
            SummaryPanel.Controls.Add(btnPlayAgain);
            SummaryPanel.Controls.Add(lblDrawGame);
            SummaryPanel.Controls.Add(lblWinGame);
            SummaryPanel.Location = new Point(31, 23);
            SummaryPanel.Name = "SummaryPanel";
            SummaryPanel.Size = new Size(754, 404);
            SummaryPanel.TabIndex = 21;
            SummaryPanel.Visible = false;
            // 
            // theirPointsLbl
            // 
            theirPointsLbl.AutoSize = true;
            theirPointsLbl.Font = new Font("Calibri", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            theirPointsLbl.Location = new Point(550, 177);
            theirPointsLbl.Name = "theirPointsLbl";
            theirPointsLbl.Size = new Size(0, 35);
            theirPointsLbl.TabIndex = 18;
            // 
            // myPointsLbl
            // 
            myPointsLbl.AutoSize = true;
            myPointsLbl.Font = new Font("Calibri", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            myPointsLbl.Location = new Point(140, 177);
            myPointsLbl.Name = "myPointsLbl";
            myPointsLbl.Size = new Size(0, 35);
            myPointsLbl.TabIndex = 17;
            // 
            // lblMyPoints
            // 
            lblMyPoints.AutoSize = true;
            lblMyPoints.BackColor = Color.Salmon;
            lblMyPoints.BorderStyle = BorderStyle.Fixed3D;
            lblMyPoints.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMyPoints.Location = new Point(81, 109);
            lblMyPoints.Name = "lblMyPoints";
            lblMyPoints.Size = new Size(209, 43);
            lblMyPoints.TabIndex = 2;
            lblMyPoints.Text = "Moje punkty:";
            // 
            // lblTheirPoints
            // 
            lblTheirPoints.AutoSize = true;
            lblTheirPoints.BackColor = Color.PaleTurquoise;
            lblTheirPoints.BorderStyle = BorderStyle.Fixed3D;
            lblTheirPoints.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTheirPoints.Location = new Point(464, 109);
            lblTheirPoints.Name = "lblTheirPoints";
            lblTheirPoints.Size = new Size(220, 43);
            lblTheirPoints.TabIndex = 1;
            lblTheirPoints.Text = "Twoje punkty:";
            // 
            // lblGameResultsStatement
            // 
            lblGameResultsStatement.AutoSize = true;
            lblGameResultsStatement.BackColor = SystemColors.GradientActiveCaption;
            lblGameResultsStatement.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameResultsStatement.Location = new Point(232, 9);
            lblGameResultsStatement.Name = "lblGameResultsStatement";
            lblGameResultsStatement.Size = new Size(282, 37);
            lblGameResultsStatement.TabIndex = 0;
            lblGameResultsStatement.Text = "Oto wyniki rozgrywki:";
            // 
            // lblLoseGame
            // 
            lblLoseGame.AutoSize = true;
            lblLoseGame.BackColor = Color.SandyBrown;
            lblLoseGame.BorderStyle = BorderStyle.Fixed3D;
            lblLoseGame.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoseGame.Location = new Point(96, 282);
            lblLoseGame.Name = "lblLoseGame";
            lblLoseGame.Size = new Size(603, 43);
            lblLoseGame.TabIndex = 11;
            lblLoseGame.Text = "Przegrałeś. Powodzenia następnym razem.";
            lblLoseGame.Visible = false;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.LavenderBlush;
            btnPlayAgain.Location = new Point(290, 358);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(140, 43);
            btnPlayAgain.TabIndex = 16;
            btnPlayAgain.Text = "Zagraj jeszcze raz";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnAgain_Click;
            // 
            // lblDrawGame
            // 
            lblDrawGame.AutoSize = true;
            lblDrawGame.BackColor = Color.PaleTurquoise;
            lblDrawGame.BorderStyle = BorderStyle.Fixed3D;
            lblDrawGame.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawGame.Location = new Point(255, 282);
            lblDrawGame.Name = "lblDrawGame";
            lblDrawGame.Size = new Size(200, 43);
            lblDrawGame.TabIndex = 13;
            lblDrawGame.Text = "Mamy remis.";
            lblDrawGame.Visible = false;
            // 
            // lblWinGame
            // 
            lblWinGame.AutoSize = true;
            lblWinGame.BackColor = Color.YellowGreen;
            lblWinGame.BorderStyle = BorderStyle.Fixed3D;
            lblWinGame.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblWinGame.Location = new Point(210, 282);
            lblWinGame.Name = "lblWinGame";
            lblWinGame.Size = new Size(315, 43);
            lblWinGame.TabIndex = 12;
            lblWinGame.Text = "Wygrałeś! Gratulacje!";
            lblWinGame.Visible = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(SummaryPanel);
            Controls.Add(GamePanel);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            GamePanel.ResumeLayout(false);
            GamePanel.PerformLayout();
            SummaryPanel.ResumeLayout(false);
            SummaryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblChooseItemStatement;
        private Button btnScissors;
        private Button btnPaper;
        private Button btnStone;
        private Button btnEndGame;
        private Label lblWin;
        private Label lblDraw;
        private Label lblLose;
        private Label lblPlayAnotherRoundStatement;
        private Panel GamePanel;
        private Panel SummaryPanel;
        private Label lblMyPoints;
        private Label lblTheirPoints;
        private Label lblGameResultsStatement;
        private Label lblLoseGame;
        private Button btnPlayAgain;
        private Label lblDrawGame;
        private Label lblWinGame;
        private Label myPointsLbl;
        private Label theirPointsLbl;
    }
}
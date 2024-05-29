namespace KamienPapierNozyce_App
{
    partial class GameInitialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInitialization));
            btnTAK = new Button();
            btnNIE = new Button();
            btnContinue = new Button();
            lblStartingStatement = new Label();
            lblRules = new Label();
            GameInitializationPanel = new Panel();
            StartPanel = new Panel();
            btnStartGame = new Button();
            GameInitializationPanel.SuspendLayout();
            StartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnTAK
            // 
            btnTAK.BackColor = SystemColors.GradientActiveCaption;
            btnTAK.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnTAK.Location = new Point(83, 173);
            btnTAK.Name = "btnTAK";
            btnTAK.Size = new Size(184, 99);
            btnTAK.TabIndex = 1;
            btnTAK.Text = "TAK";
            btnTAK.UseVisualStyleBackColor = false;
            btnTAK.Click += Button1_Click;
            // 
            // btnNIE
            // 
            btnNIE.BackColor = SystemColors.ButtonHighlight;
            btnNIE.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnNIE.Location = new Point(493, 173);
            btnNIE.Name = "btnNIE";
            btnNIE.Size = new Size(184, 99);
            btnNIE.TabIndex = 2;
            btnNIE.Text = "NIE";
            btnNIE.UseVisualStyleBackColor = false;
            btnNIE.Click += Button2_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.LemonChiffon;
            btnContinue.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinue.Location = new Point(273, 333);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(219, 84);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Kontynuj";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Visible = false;
            btnContinue.Click += Button3_Click;
            // 
            // lblStartingStatement
            // 
            lblStartingStatement.AutoSize = true;
            lblStartingStatement.BackColor = SystemColors.GradientActiveCaption;
            lblStartingStatement.BorderStyle = BorderStyle.Fixed3D;
            lblStartingStatement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartingStatement.Location = new Point(83, 12);
            lblStartingStatement.Name = "lblStartingStatement";
            lblStartingStatement.Size = new Size(594, 30);
            lblStartingStatement.TabIndex = 5;
            lblStartingStatement.Text = "Zagrajmy w grę papier, kamień, nożyce. Czy chcesz poznać zasady?";
            // 
            // lblRules
            // 
            lblRules.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRules.Location = new Point(3, 68);
            lblRules.Name = "lblRules";
            lblRules.Size = new Size(746, 171);
            lblRules.TabIndex = 6;
            lblRules.Text = resources.GetString("lblRules.Text");
            lblRules.TextAlign = ContentAlignment.MiddleCenter;
            lblRules.Visible = false;
            // 
            // GameInitializationPanel
            // 
            GameInitializationPanel.Controls.Add(lblStartingStatement);
            GameInitializationPanel.Controls.Add(btnContinue);
            GameInitializationPanel.Controls.Add(lblRules);
            GameInitializationPanel.Controls.Add(btnNIE);
            GameInitializationPanel.Controls.Add(btnTAK);
            GameInitializationPanel.Location = new Point(22, 8);
            GameInitializationPanel.Name = "GameInitializationPanel";
            GameInitializationPanel.Size = new Size(756, 430);
            GameInitializationPanel.TabIndex = 7;
            GameInitializationPanel.Visible = false;
            // 
            // StartPanel
            // 
            StartPanel.Controls.Add(btnStartGame);
            StartPanel.Location = new Point(173, 55);
            StartPanel.Name = "StartPanel";
            StartPanel.Size = new Size(504, 249);
            StartPanel.TabIndex = 7;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.CornflowerBlue;
            btnStartGame.Font = new Font("Courier New", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartGame.ForeColor = SystemColors.ActiveCaptionText;
            btnStartGame.Location = new Point(51, 12);
            btnStartGame.Margin = new Padding(3, 4, 3, 4);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(395, 233);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "ROZPOCZNIJ GRĘ";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += BtnStartGame_Click;
            // 
            // GameInitialization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(GameInitializationPanel);
            Controls.Add(StartPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GameInitialization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameInitialization";
            GameInitializationPanel.ResumeLayout(false);
            GameInitializationPanel.PerformLayout();
            StartPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnTAK;
        private Button btnNIE;
        private Button btnContinue;
        private Label lblStartingStatement;
        private Label lblRules;
        private Panel GameInitializationPanel;
        private Panel StartPanel;
        private Button btnStartGame;
    }
}
namespace RacingTime
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnGameMode = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlHowToPlay = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnBackFromHowTo = new System.Windows.Forms.Button();
            this.pnlHowToPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(282, 87);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 50);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Bắt đầu";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnGameMode
            // 
            this.btnGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameMode.Location = new System.Drawing.Point(282, 143);
            this.btnGameMode.Name = "btnGameMode";
            this.btnGameMode.Size = new System.Drawing.Size(200, 50);
            this.btnGameMode.TabIndex = 0;
            this.btnGameMode.Text = "Chế độ";
            this.btnGameMode.UseVisualStyleBackColor = true;
            this.btnGameMode.Click += new System.EventHandler(this.btnGameMode_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(282, 199);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 50);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHowTo
            // 
            this.btnHowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowTo.Location = new System.Drawing.Point(282, 255);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(200, 50);
            this.btnHowTo.TabIndex = 0;
            this.btnHowTo.Text = "Hướng dẫn";
            this.btnHowTo.UseVisualStyleBackColor = true;
            this.btnHowTo.Click += new System.EventHandler(this.btnHowTo_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(282, 311);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(200, 50);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pnlHowToPlay
            // 
            this.pnlHowToPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHowToPlay.BackColor = System.Drawing.Color.DarkGray;
            this.pnlHowToPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHowToPlay.Controls.Add(this.btnBackFromHowTo);
            this.pnlHowToPlay.Controls.Add(this.lblInstruction);
            this.pnlHowToPlay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlHowToPlay.Location = new System.Drawing.Point(137, 47);
            this.pnlHowToPlay.Name = "pnlHowToPlay";
            this.pnlHowToPlay.Size = new System.Drawing.Size(500, 350);
            this.pnlHowToPlay.TabIndex = 1;
            this.pnlHowToPlay.Visible = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(0, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Padding = new System.Windows.Forms.Padding(20);
            this.lblInstruction.Size = new System.Drawing.Size(498, 348);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = resources.GetString("lblInstruction.Text");
            // 
            // btnBackFromHowTo
            // 
            this.btnBackFromHowTo.ForeColor = System.Drawing.Color.Black;
            this.btnBackFromHowTo.Location = new System.Drawing.Point(4, 322);
            this.btnBackFromHowTo.Name = "btnBackFromHowTo";
            this.btnBackFromHowTo.Size = new System.Drawing.Size(75, 23);
            this.btnBackFromHowTo.TabIndex = 2;
            this.btnBackFromHowTo.Text = "Back";
            this.btnBackFromHowTo.UseVisualStyleBackColor = true;
            this.btnBackFromHowTo.Click += new System.EventHandler(this.btnBackFromHowTo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHowToPlay);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnHowTo);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnGameMode);
            this.Controls.Add(this.btnStartGame);
            this.Name = "Menu";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlHowToPlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnGameMode;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHowTo;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlHowToPlay;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnBackFromHowTo;
    }
}
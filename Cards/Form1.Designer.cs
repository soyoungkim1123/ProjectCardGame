namespace Cards
{
    partial class Form1
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
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.PanelUser1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.PanelUser2 = new System.Windows.Forms.Panel();
            this.lbUser1Name = new System.Windows.Forms.Label();
            this.lbUser2Name = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.panel_turnChoice = new System.Windows.Forms.Panel();
            this.lbFirstCard = new System.Windows.Forms.Label();
            this.lbSecondCard = new System.Windows.Forms.Label();
            this.lbThirdCard = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lbChooseCard = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.PanelPlayer.Location = new System.Drawing.Point(11, 524);
            this.PanelPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(1211, 110);
            this.PanelPlayer.TabIndex = 10;
            // 
            // PanelUser1
            // 
            this.PanelUser1.BackColor = System.Drawing.Color.Transparent;
            this.PanelUser1.Location = new System.Drawing.Point(11, 53);
            this.PanelUser1.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUser1.Name = "PanelUser1";
            this.PanelUser1.Size = new System.Drawing.Size(950, 70);
            this.PanelUser1.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Thistle;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(517, 474);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 44);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Game Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.Thistle;
            this.btnEndTurn.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.Location = new System.Drawing.Point(1091, 457);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(130, 62);
            this.btnEndTurn.TabIndex = 14;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // PanelUser2
            // 
            this.PanelUser2.BackColor = System.Drawing.Color.Transparent;
            this.PanelUser2.Location = new System.Drawing.Point(284, 166);
            this.PanelUser2.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUser2.Name = "PanelUser2";
            this.PanelUser2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelUser2.Size = new System.Drawing.Size(950, 70);
            this.PanelUser2.TabIndex = 9;
            // 
            // lbUser1Name
            // 
            this.lbUser1Name.AutoSize = true;
            this.lbUser1Name.BackColor = System.Drawing.Color.Transparent;
            this.lbUser1Name.Font = new System.Drawing.Font("Berlin Sans FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser1Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUser1Name.Location = new System.Drawing.Point(12, 14);
            this.lbUser1Name.Name = "lbUser1Name";
            this.lbUser1Name.Size = new System.Drawing.Size(86, 37);
            this.lbUser1Name.TabIndex = 16;
            this.lbUser1Name.Text = "User1";
            // 
            // lbUser2Name
            // 
            this.lbUser2Name.AutoSize = true;
            this.lbUser2Name.BackColor = System.Drawing.Color.Transparent;
            this.lbUser2Name.Font = new System.Drawing.Font("Berlin Sans FB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser2Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUser2Name.Location = new System.Drawing.Point(1084, 125);
            this.lbUser2Name.Name = "lbUser2Name";
            this.lbUser2Name.Size = new System.Drawing.Size(92, 37);
            this.lbUser2Name.TabIndex = 17;
            this.lbUser2Name.Text = "User2";
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerName.Font = new System.Drawing.Font("Berlin Sans FB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPlayerName.Location = new System.Drawing.Point(9, 478);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(71, 37);
            this.lbPlayerName.TabIndex = 18;
            this.lbPlayerName.Text = "You";
            // 
            // panel_turnChoice
            // 
            this.panel_turnChoice.BackColor = System.Drawing.Color.Transparent;
            this.panel_turnChoice.Location = new System.Drawing.Point(348, 180);
            this.panel_turnChoice.Margin = new System.Windows.Forms.Padding(2);
            this.panel_turnChoice.Name = "panel_turnChoice";
            this.panel_turnChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_turnChoice.Size = new System.Drawing.Size(550, 193);
            this.panel_turnChoice.TabIndex = 10;
            // 
            // lbFirstCard
            // 
            this.lbFirstCard.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstCard.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstCard.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbFirstCard.Location = new System.Drawing.Point(340, 372);
            this.lbFirstCard.Name = "lbFirstCard";
            this.lbFirstCard.Size = new System.Drawing.Size(171, 125);
            this.lbFirstCard.TabIndex = 20;
            this.lbFirstCard.Text = "Your pick";
            this.lbFirstCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSecondCard
            // 
            this.lbSecondCard.BackColor = System.Drawing.Color.Transparent;
            this.lbSecondCard.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondCard.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbSecondCard.Location = new System.Drawing.Point(539, 372);
            this.lbSecondCard.Name = "lbSecondCard";
            this.lbSecondCard.Size = new System.Drawing.Size(171, 125);
            this.lbSecondCard.TabIndex = 21;
            this.lbSecondCard.Text = "User1\'s pick";
            this.lbSecondCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbThirdCard
            // 
            this.lbThirdCard.BackColor = System.Drawing.Color.Transparent;
            this.lbThirdCard.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThirdCard.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbThirdCard.Location = new System.Drawing.Point(741, 372);
            this.lbThirdCard.Name = "lbThirdCard";
            this.lbThirdCard.Size = new System.Drawing.Size(171, 125);
            this.lbThirdCard.TabIndex = 21;
            this.lbThirdCard.Text = "User2\'s pick";
            this.lbThirdCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(517, 446);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(203, 23);
            this.txtPlayerName.TabIndex = 22;
            this.txtPlayerName.Text = "Enter your name";
            this.txtPlayerName.Enter += new System.EventHandler(this.txtPlayerName_Enter);
            this.txtPlayerName.Leave += new System.EventHandler(this.txtPlayerName_Enter);
            // 
            // lbChooseCard
            // 
            this.lbChooseCard.BackColor = System.Drawing.Color.Transparent;
            this.lbChooseCard.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseCard.ForeColor = System.Drawing.Color.White;
            this.lbChooseCard.Location = new System.Drawing.Point(145, 120);
            this.lbChooseCard.Name = "lbChooseCard";
            this.lbChooseCard.Size = new System.Drawing.Size(942, 44);
            this.lbChooseCard.TabIndex = 23;
            this.lbChooseCard.Text = "Please choose a card!";
            this.lbChooseCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Thistle;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(516, 474);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(203, 44);
            this.btnRestart.TabIndex = 24;
            this.btnRestart.Text = "New Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbSystem
            // 
            this.lbSystem.BackColor = System.Drawing.Color.Transparent;
            this.lbSystem.Font = new System.Drawing.Font("Berlin Sans FB", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystem.ForeColor = System.Drawing.Color.White;
            this.lbSystem.Location = new System.Drawing.Point(222, 238);
            this.lbSystem.Name = "lbSystem";
            this.lbSystem.Size = new System.Drawing.Size(830, 123);
            this.lbSystem.TabIndex = 25;
            this.lbSystem.Text = "System Message";
            this.lbSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Cards.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1234, 650);
            this.Controls.Add(this.lbSystem);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.lbChooseCard);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbThirdCard);
            this.Controls.Add(this.lbSecondCard);
            this.Controls.Add(this.lbFirstCard);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.lbUser2Name);
            this.Controls.Add(this.lbUser1Name);
            this.Controls.Add(this.PanelPlayer);
            this.Controls.Add(this.PanelUser1);
            this.Controls.Add(this.PanelUser2);
            this.Controls.Add(this.panel_turnChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel PanelPlayer;
        internal System.Windows.Forms.Panel PanelUser1;
        internal System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEndTurn;
        internal System.Windows.Forms.Panel PanelUser2;
        private System.Windows.Forms.Label lbUser1Name;
        private System.Windows.Forms.Label lbUser2Name;
        private System.Windows.Forms.Label lbPlayerName;
        internal System.Windows.Forms.Panel panel_turnChoice;
        private System.Windows.Forms.Label lbThirdCard;
        private System.Windows.Forms.Label lbSecondCard;
        private System.Windows.Forms.Label lbFirstCard;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lbChooseCard;
        internal System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbSystem;
    }
}
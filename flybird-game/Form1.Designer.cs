
namespace Flappy_Bird
{
    partial class FormBig
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox FormBackground;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBig));
            this.TimerTick = new System.Windows.Forms.Timer(this.components);
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.FinalScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScorePosition = new System.Windows.Forms.Label();
            this.PILLAR6B = new System.Windows.Forms.PictureBox();
            this.PILLAR5B = new System.Windows.Forms.PictureBox();
            this.PILLAR5A = new System.Windows.Forms.PictureBox();
            this.PILLAR6A = new System.Windows.Forms.PictureBox();
            this.PILLAR4B = new System.Windows.Forms.PictureBox();
            this.PILLAR4A = new System.Windows.Forms.PictureBox();
            this.PILLAR2B = new System.Windows.Forms.PictureBox();
            this.PILLAR2A = new System.Windows.Forms.PictureBox();
            this.PILLAR3B = new System.Windows.Forms.PictureBox();
            this.PILLAR3A = new System.Windows.Forms.PictureBox();
            this.Pillar1B = new System.Windows.Forms.PictureBox();
            this.Pillar1A = new System.Windows.Forms.PictureBox();
            this.object_bush_3 = new System.Windows.Forms.PictureBox();
            this.object_bush_2 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.object_bush_1 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            FormBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(FormBackground)).BeginInit();
            this.ExitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR6B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR5B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR5A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR6A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR4B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR4A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR2B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR2A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR3B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR3A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_bush_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_bush_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_bush_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBackground
            // 
            resources.ApplyResources(FormBackground, "FormBackground");
            FormBackground.BackColor = System.Drawing.Color.Transparent;
            FormBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FormBackground.Cursor = System.Windows.Forms.Cursors.Cross;
            FormBackground.Image = global::Flying_Bird_Game.Properties.Resources.Background;
            FormBackground.Name = "FormBackground";
            FormBackground.TabStop = false;
            // 
            // TimerTick
            // 
            this.TimerTick.Enabled = true;
            this.TimerTick.Interval = 50;
            this.TimerTick.Tick += new System.EventHandler(this.TimerTick_Tick);
            // 
            // ExitPanel
            // 
            this.ExitPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ExitPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExitPanel.Controls.Add(this.FinalScore);
            this.ExitPanel.Controls.Add(this.label3);
            this.ExitPanel.Controls.Add(this.Restart);
            this.ExitPanel.Controls.Add(this.pictureBox1);
            this.ExitPanel.Controls.Add(this.EXIT);
            this.ExitPanel.Controls.Add(this.label1);
            resources.ApplyResources(this.ExitPanel, "ExitPanel");
            this.ExitPanel.Name = "ExitPanel";
            // 
            // FinalScore
            // 
            resources.ApplyResources(this.FinalScore, "FinalScore");
            this.FinalScore.ForeColor = System.Drawing.Color.Red;
            this.FinalScore.Name = "FinalScore";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Restart
            // 
            resources.ApplyResources(this.Restart, "Restart");
            this.Restart.Name = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // EXIT
            // 
            resources.ApplyResources(this.EXIT, "EXIT");
            this.EXIT.Name = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Name = "label2";
            // 
            // ScorePosition
            // 
            resources.ApplyResources(this.ScorePosition, "ScorePosition");
            this.ScorePosition.BackColor = System.Drawing.Color.Snow;
            this.ScorePosition.Name = "ScorePosition";
            // 
            // PILLAR6B
            // 
            this.PILLAR6B.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR6B, "PILLAR6B");
            this.PILLAR6B.Name = "PILLAR6B";
            this.PILLAR6B.TabStop = false;
            // 
            // PILLAR5B
            // 
            this.PILLAR5B.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR5B, "PILLAR5B");
            this.PILLAR5B.Name = "PILLAR5B";
            this.PILLAR5B.TabStop = false;
            // 
            // PILLAR5A
            // 
            this.PILLAR5A.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR5A, "PILLAR5A");
            this.PILLAR5A.Name = "PILLAR5A";
            this.PILLAR5A.TabStop = false;
            // 
            // PILLAR6A
            // 
            this.PILLAR6A.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR6A, "PILLAR6A");
            this.PILLAR6A.Name = "PILLAR6A";
            this.PILLAR6A.TabStop = false;
            // 
            // PILLAR4B
            // 
            this.PILLAR4B.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR4B, "PILLAR4B");
            this.PILLAR4B.Name = "PILLAR4B";
            this.PILLAR4B.TabStop = false;
            // 
            // PILLAR4A
            // 
            this.PILLAR4A.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR4A, "PILLAR4A");
            this.PILLAR4A.Name = "PILLAR4A";
            this.PILLAR4A.TabStop = false;
            // 
            // PILLAR2B
            // 
            this.PILLAR2B.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR2B, "PILLAR2B");
            this.PILLAR2B.Name = "PILLAR2B";
            this.PILLAR2B.TabStop = false;
            // 
            // PILLAR2A
            // 
            this.PILLAR2A.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR2A, "PILLAR2A");
            this.PILLAR2A.Name = "PILLAR2A";
            this.PILLAR2A.TabStop = false;
            // 
            // PILLAR3B
            // 
            this.PILLAR3B.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR3B, "PILLAR3B");
            this.PILLAR3B.Name = "PILLAR3B";
            this.PILLAR3B.TabStop = false;
            // 
            // PILLAR3A
            // 
            this.PILLAR3A.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.PILLAR3A, "PILLAR3A");
            this.PILLAR3A.Name = "PILLAR3A";
            this.PILLAR3A.TabStop = false;
            // 
            // Pillar1B
            // 
            this.Pillar1B.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Pillar1B, "Pillar1B");
            this.Pillar1B.Name = "Pillar1B";
            this.Pillar1B.TabStop = false;
            // 
            // Pillar1A
            // 
            this.Pillar1A.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Pillar1A, "Pillar1A");
            this.Pillar1A.Name = "Pillar1A";
            this.Pillar1A.TabStop = false;
            // 
            // object_bush_3
            // 
            this.object_bush_3.BackColor = System.Drawing.Color.Transparent;
            this.object_bush_3.Image = global::Flying_Bird_Game.Properties.Resources.Bush;
            resources.ApplyResources(this.object_bush_3, "object_bush_3");
            this.object_bush_3.Name = "object_bush_3";
            this.object_bush_3.TabStop = false;
            // 
            // object_bush_2
            // 
            this.object_bush_2.BackColor = System.Drawing.Color.Transparent;
            this.object_bush_2.Image = global::Flying_Bird_Game.Properties.Resources.Bush;
            resources.ApplyResources(this.object_bush_2, "object_bush_2");
            this.object_bush_2.Name = "object_bush_2";
            this.object_bush_2.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Flying_Bird_Game.Properties.Resources.Bird;
            resources.ApplyResources(this.Player, "Player");
            this.Player.Name = "Player";
            this.Player.TabStop = false;
            // 
            // object_bush_1
            // 
            this.object_bush_1.BackColor = System.Drawing.Color.Transparent;
            this.object_bush_1.Image = global::Flying_Bird_Game.Properties.Resources.Bush;
            resources.ApplyResources(this.object_bush_1, "object_bush_1");
            this.object_bush_1.Name = "object_bush_1";
            this.object_bush_1.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::Flying_Bird_Game.Properties.Resources.Ground1;
            resources.ApplyResources(this.Ground, "Ground");
            this.Ground.Name = "Ground";
            this.Ground.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::Flying_Bird_Game.Properties.Resources.Xbutton;
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormBig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ScorePosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PILLAR6B);
            this.Controls.Add(this.PILLAR5B);
            this.Controls.Add(this.PILLAR5A);
            this.Controls.Add(this.PILLAR6A);
            this.Controls.Add(this.PILLAR4B);
            this.Controls.Add(this.PILLAR4A);
            this.Controls.Add(this.PILLAR2B);
            this.Controls.Add(this.PILLAR2A);
            this.Controls.Add(this.PILLAR3B);
            this.Controls.Add(this.PILLAR3A);
            this.Controls.Add(this.Pillar1B);
            this.Controls.Add(this.Pillar1A);
            this.Controls.Add(this.ExitPanel);
            this.Controls.Add(this.object_bush_3);
            this.Controls.Add(this.object_bush_2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.object_bush_1);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(FormBackground);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormBig";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBig_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(FormBackground)).EndInit();
            this.ExitPanel.ResumeLayout(false);
            this.ExitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR6B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR5B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR5A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR6A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR4B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR4A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR2B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR2A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR3B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PILLAR3A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_bush_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_bush_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_bush_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox object_bush_1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox object_bush_2;
        private System.Windows.Forms.PictureBox object_bush_3;
        private System.Windows.Forms.Timer TimerTick;
        private System.Windows.Forms.Panel ExitPanel;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pillar1A;
        private System.Windows.Forms.PictureBox Pillar1B;
        private System.Windows.Forms.PictureBox PILLAR3B;
        private System.Windows.Forms.PictureBox PILLAR3A;
        private System.Windows.Forms.PictureBox PILLAR2A;
        private System.Windows.Forms.PictureBox PILLAR2B;
        private System.Windows.Forms.PictureBox PILLAR4B;
        private System.Windows.Forms.PictureBox PILLAR4A;
        private System.Windows.Forms.PictureBox PILLAR5B;
        private System.Windows.Forms.PictureBox PILLAR5A;
        private System.Windows.Forms.PictureBox PILLAR6B;
        private System.Windows.Forms.PictureBox PILLAR6A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScorePosition;
        private System.Windows.Forms.Label FinalScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label label4;
    }
}


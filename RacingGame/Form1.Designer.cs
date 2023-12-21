
namespace RacingGame
{
    partial class bg1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bg1));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.playersCar = new System.Windows.Forms.PictureBox();
            this.moving = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.BackGround2 = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.TextBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.buttonReStart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackgroundImage = global::RacingGame.Properties.Resources.Road;
            resources.ApplyResources(this.pictureBoxMain, "pictureBoxMain");
            this.pictureBoxMain.InitialImage = global::RacingGame.Properties.Resources.Road;
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.TabStop = false;
            // 
            // playersCar
            // 
            this.playersCar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.playersCar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playersCar.BackgroundImage = global::RacingGame.Properties.Resources.car1;
            resources.ApplyResources(this.playersCar, "playersCar");
            this.playersCar.Image = global::RacingGame.Properties.Resources.car11;
            this.playersCar.Name = "playersCar";
            this.playersCar.TabStop = false;
            this.playersCar.DoubleClick += new System.EventHandler(this.playerCar_DoubleClick);
            this.playersCar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerCar_MouseClick);
            // 
            // moving
            // 
            this.moving.Enabled = true;
            this.moving.Interval = 20;
            this.moving.Tick += new System.EventHandler(this.moving_Tick);
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.BackgroundImage = global::RacingGame.Properties.Resources.Road;
            resources.ApplyResources(this.pictureBoxBG, "pictureBoxBG");
            this.pictureBoxBG.InitialImage = global::RacingGame.Properties.Resources.Road;
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.TabStop = false;
            // 
            // BackGround
            // 
            this.BackGround.Image = global::RacingGame.Properties.Resources.Road;
            this.BackGround.InitialImage = global::RacingGame.Properties.Resources.Road;
            resources.ApplyResources(this.BackGround, "BackGround");
            this.BackGround.Name = "BackGround";
            this.BackGround.TabStop = false;
            this.BackGround.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playerCar_PreviewKeyDown);
            // 
            // BackGround2
            // 
            this.BackGround2.Image = global::RacingGame.Properties.Resources.Road;
            resources.ApplyResources(this.BackGround2, "BackGround2");
            this.BackGround2.InitialImage = global::RacingGame.Properties.Resources.Road;
            this.BackGround2.Name = "BackGround2";
            this.BackGround2.TabStop = false;
            // 
            // labelCoins
            // 
            resources.ApplyResources(this.labelCoins, "labelCoins");
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.SystemColors.GrayText;
            this.car1.Image = global::RacingGame.Properties.Resources.images;
            resources.ApplyResources(this.car1, "car1");
            this.car1.Name = "car1";
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.car2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.car2.BackgroundImage = global::RacingGame.Properties.Resources.images__3_;
            resources.ApplyResources(this.car2, "car2");
            this.car2.Image = global::RacingGame.Properties.Resources.car_2;
            this.car2.InitialImage = global::RacingGame.Properties.Resources.car21;
            this.car2.Name = "car2";
            this.car2.TabStop = false;
            // 
            // buttonReStart
            // 
            this.buttonReStart.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.buttonReStart, "buttonReStart");
            this.buttonReStart.ForeColor = System.Drawing.Color.Purple;
            this.buttonReStart.Name = "buttonReStart";
            this.buttonReStart.UseVisualStyleBackColor = false;
            this.buttonReStart.Click += new System.EventHandler(this.buttonReStart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.SystemColors.GrayText;
            this.coin.Image = global::RacingGame.Properties.Resources.coin;
            this.coin.InitialImage = global::RacingGame.Properties.Resources.coin;
            resources.ApplyResources(this.coin, "coin");
            this.coin.Name = "coin";
            this.coin.TabStop = false;
            // 
            // bg1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::RacingGame.Properties.Resources.Road;
            this.Controls.Add(this.coin);
            this.Controls.Add(this.buttonReStart);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.playersCar);
            this.Controls.Add(this.BackGround);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.pictureBoxBG);
            this.Controls.Add(this.BackGround2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bg1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox playersCar; 
        private System.Windows.Forms.Timer moving;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.PictureBox BackGround2;
        private System.Windows.Forms.TextBox labelCoins;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.Button buttonReStart;
        private System.Windows.Forms.PictureBox coin;
    }
}


namespace Final
{
    partial class The_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(The_Form));
            this.tmr_Up = new System.Windows.Forms.Timer(this.components);
            this.tmr_Right = new System.Windows.Forms.Timer(this.components);
            this.tmr_Left = new System.Windows.Forms.Timer(this.components);
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.tmr_Down = new System.Windows.Forms.Timer(this.components);
            this.pb_leftWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftWall)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_Up
            // 
            this.tmr_Up.Interval = 10;
            this.tmr_Up.Tick += new System.EventHandler(this.tmr_Up_Tick);
            // 
            // tmr_Right
            // 
            this.tmr_Right.Interval = 10;
            this.tmr_Right.Tick += new System.EventHandler(this.tmr_Right_Tick);
            // 
            // tmr_Left
            // 
            this.tmr_Left.Interval = 10;
            this.tmr_Left.Tick += new System.EventHandler(this.tmr_Left_Tick);
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = ((System.Drawing.Image)(resources.GetObject("pb_Player.Image")));
            this.pb_Player.Location = new System.Drawing.Point(286, 226);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(31, 40);
            this.pb_Player.TabIndex = 401;
            this.pb_Player.TabStop = false;
            // 
            // tmr_Down
            // 
            this.tmr_Down.Interval = 10;
            this.tmr_Down.Tick += new System.EventHandler(this.tmr_Down_Tick);
            // 
            // pb_leftWall
            // 
            this.pb_leftWall.BackColor = System.Drawing.Color.Transparent;
            this.pb_leftWall.Image = ((System.Drawing.Image)(resources.GetObject("pb_leftWall.Image")));
            this.pb_leftWall.Location = new System.Drawing.Point(0, -2);
            this.pb_leftWall.Name = "pb_leftWall";
            this.pb_leftWall.Size = new System.Drawing.Size(20, 447);
            this.pb_leftWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_leftWall.TabIndex = 402;
            this.pb_leftWall.TabStop = false;
            // 
            // The_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(575, 444);
            this.Controls.Add(this.pb_leftWall);
            this.Controls.Add(this.pb_Player);
            this.Name = "The_Form";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.The_Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.The_Form_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_Up;
        private System.Windows.Forms.Timer tmr_Right;
        private System.Windows.Forms.Timer tmr_Left;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_Down;
        private System.Windows.Forms.PictureBox pb_leftWall;
    }
}


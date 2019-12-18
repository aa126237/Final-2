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
            this.pb_Ground = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.tmr_Gravity = new System.Windows.Forms.Timer(this.components);
            this.tmr_Up = new System.Windows.Forms.Timer(this.components);
            this.tmr_Right = new System.Windows.Forms.Timer(this.components);
            this.tmr_Left = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Ground
            // 
            this.pb_Ground.BackColor = System.Drawing.Color.Green;
            this.pb_Ground.Location = new System.Drawing.Point(-8, 409);
            this.pb_Ground.Name = "pb_Ground";
            this.pb_Ground.Size = new System.Drawing.Size(806, 62);
            this.pb_Ground.TabIndex = 0;
            this.pb_Ground.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Red;
            this.pb_Player.Location = new System.Drawing.Point(354, 181);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(51, 50);
            this.pb_Player.TabIndex = 1;
            this.pb_Player.TabStop = false;
            // 
            // tmr_Gravity
            // 
            this.tmr_Gravity.Enabled = true;
            this.tmr_Gravity.Interval = 10;
            this.tmr_Gravity.Tick += new System.EventHandler(this.tmr_Gravity_Tick);
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
            // The_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Ground);
            this.Name = "The_Form";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.The_Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.The_Form_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_Gravity;
        private System.Windows.Forms.Timer tmr_Up;
        private System.Windows.Forms.Timer tmr_Right;
        private System.Windows.Forms.Timer tmr_Left;
    }
}


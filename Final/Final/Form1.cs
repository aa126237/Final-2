using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class The_Form : Form
    {

        public The_Form()
        {
            InitializeComponent();
        }

        int health = 10;
        string healthstr = "10";

        private void The_Form_Load(object sender, EventArgs e)
        {
            var enemy1 = new PictureBox
            {
                Name = "enemy",
                Size = new Size(51, 51),
                Location = new Point(100, 100),
                Image = Properties.Resources.Demon,
                BackColor = Color.Transparent,
            };
            this.Controls.Add(enemy1);
            if(pb_Player.Bounds.IntersectsWith(enemy1.Bounds))
            {
                healthstr = Convert.ToString(health);
                lbl_health.Text = healthstr;
            }
        }

        private void tmr_Up_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_topWall.Bounds))
            {
                pb_Player.Top -= Player.playerMoveSpeed;
            }
        }

        private void tmr_Down_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_bottomeWall.Bounds))
            {
                pb_Player.Top += Player.playerMoveSpeed;
            }
        }
        
        private void tmr_Right_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_rightWall.Bounds))
            {
                pb_Player.Left += Player.playerMoveSpeed;
            }
        }

        private void tmr_Left_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_leftWall.Bounds))
            {
                pb_Player.Left -= Player.playerMoveSpeed;
            }
        }

        private void The_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tmr_Up.Start();
            else if (e.KeyCode == Keys.Right)
                tmr_Right.Start();
            else if (e.KeyCode == Keys.Left)
                tmr_Left.Start();
            else if (e.KeyCode == Keys.Down)
                tmr_Down.Start();
        }
        
        private void The_Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tmr_Up.Stop();
            else if (e.KeyCode == Keys.Right)
                tmr_Right.Stop();
            else if (e.KeyCode == Keys.Left)
                tmr_Left.Stop();
            else if (e.KeyCode == Keys.Down)
                tmr_Down.Stop();
        }
    }
}

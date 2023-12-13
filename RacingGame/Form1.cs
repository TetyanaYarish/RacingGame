using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class bg1 : Form
    {
        private Point pos;
        private bool dragging;
        public bg1()
        {
            InitializeComponent();
            playersCar.MouseDown += MouseClickDown;
            BackGround.MouseDown += MouseClickDown;
            BackGround2.MouseDown += MouseClickDown;
            playersCar.MouseDown += MouseClickDown;
            BackGround.MouseMove += MouseClickMove;
            BackGround2.MouseMove += MouseClickMove;
            playersCar.MouseUp += MouseClickUp;
            BackGround.MouseUp += MouseClickUp;
            BackGround2.MouseUp += MouseClickUp;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                this.Close();
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X; pos.Y = e.Y;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + BackGround.Top);
            }

        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void moving_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(-50, -20);
            int l = random.Next(62, 280);
            int speed = 8;
            BackGround.Top += speed;
            int car1speed = 7;
            car1.Top += speed;
            BackGround2.Top += speed;

            if (BackGround.Top >= 50)
            {
                BackGround.Top = -20;
                BackGround2.Top = -300;

            }
            if (car1.Top >= 450)
            {
                car1.Top = r; car1.Left = l;
            }
            // if (car1.Left >= 450) car1.Top = r;
        }

        private void bg1_Load(object sender, EventArgs e)
        {

        }
        private void playerCar_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 8;
            if (e.KeyCode == Keys.Left)
            {
                playersCar.Left -= speed;
            }
        }



        private void pictureBox1_PreviewKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int speed = 8;
            if (e.KeyCode == Keys.Right)
            {
                playersCar.Left -= speed;
            }
        }


        private void playerCar_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            int speed = 10;
            if (e.KeyCode == Keys.Left)
            {
                playersCar.Left -= speed;
            }
        }


        private void playerCar_DoubleClick(object sender, EventArgs e)
        {
            int speed = 10;
            if (speed == 10)

                playersCar.Left -= 15;

        }

        private void playerCar_MouseClick(object sender, MouseEventArgs e)
        {
            int speed = 10;
            if (speed == 10)

                playersCar.Left -= 15;

        }

        private void playersCar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void bg1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if ((e.KeyCode == Keys.Left) && playersCar.Left > 67)
            {
                playersCar.Left -= speed;
            }

            else if ((e.KeyCode == Keys.Right) && playersCar.Left < 235)
            {
                playersCar.Left += speed;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void playersCar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if ((e.KeyCode == Keys.Left) && playersCar.Left > 67)
            {
                playersCar.Left -= speed;
            }

            else if ((e.KeyCode == Keys.Right) && playersCar.Left < 235)
            {
                playersCar.Left += speed;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BackGround2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        private int randomCar1PositionX { get; set; }
        private int randomCar2PositionX { get; set; }
        private int randomCar1PositionY { get; set; }
        private int randomCar2PositionY { get; set; }
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
            loseText.Visible = false;
            buttonReStart.Visible = false;
            KeyPreview = true;
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
        private void RandomPossition()
        {

            Random random = new Random();
            randomCar1PositionY = random.Next(-75, -20);
            randomCar2PositionY = random.Next(-175, -85);
            int index1 = random.Next(4);
            int index2 = random.Next(4);
            if (index1 == index2) { index1 = 1; index2 = 3; }
            int[] numbers= { 67, 121, 180, 234 };
            randomCar1PositionX = numbers[index1];
            randomCar2PositionX = numbers[index2];
          
        }

        private void moving_Tick(object sender, EventArgs e)
        {
            RandomPossition();
            int speed = 8;
            BackGround.Top += speed;
          
            car1.Top += speed;
            car2.Top += speed+1;
            BackGround2.Top += speed;

            if (BackGround.Top >= 50)
            {
                BackGround.Top = -20;
                BackGround2.Top = -300;

            }
            if (car1.Top >= 450)
            {
            car1.Top = randomCar1PositionY;
            car1.Left = randomCar1PositionX;
            car2.Top = randomCar2PositionY;
            car2.Left = randomCar2PositionX;
            }
            if (playersCar.Bounds.IntersectsWith(car1.Bounds)|| playersCar.Bounds.IntersectsWith(car2.Bounds)) {
                moving.Enabled=false;
                loseText.Visible = true;
                buttonReStart.Visible = true;

            }
            
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

      
        private void bg1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void playersCar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            int speed = 7;
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

        private void buttonReStart_Click(object sender, EventArgs e)
        {
            //car1.Top = -100;
            //car2.Top = -20;
            buttonReStart.Visible = false;
            loseText.Visible = false;
            moving.Enabled = true;

        }
    }
}

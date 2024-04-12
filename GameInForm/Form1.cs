using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameInForm
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            SetMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonMoveClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch (button.Name)
            {
                case "buttonUp":
                    {
                        this.map.OnUp(sender, e);
                        break;
                    }
                case "buttonDown":
                    {
                        this.map.OnDown(sender, e);
                        break;
                    }
                case "buttonLeft":
                    {
                        this.map.OnLeft(sender, e);
                        break;
                    }
                case "buttonRight":
                    {
                        this.map.OnRight(sender, e);
                        break;
                    }
            }

            Graphics graphics = this.CreateGraphics();
            PaintEventArgs paintEventArgs = new PaintEventArgs(graphics, this.ClientRectangle);
            this.map.UpdateMap(sender, paintEventArgs);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine('1');
            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        this.map.OnUp(sender, e);
                        break;
                    }
                case Keys.S:
                    {
                        this.map.OnDown(sender, e);
                        break;
                    }
                case Keys.A:
                    {
                        this.map.OnLeft(sender, e);
                        break;
                    }
                case Keys.D:
                    {
                        this.map.OnRight(sender, e);
                        break;
                    }
            }

            Graphics graphics = this.CreateGraphics();
            PaintEventArgs paintEventArgs = new PaintEventArgs(graphics, this.ClientRectangle);
            this.map.UpdateMap(sender, paintEventArgs);
        }
    }
}

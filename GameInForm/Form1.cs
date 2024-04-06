using GameInForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInForm
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}

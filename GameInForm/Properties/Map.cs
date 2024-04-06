using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInForm.Properties
{
    internal class Map
    {
        private List<List<char>> map = new List<List<char>>();
        private Player player = new Player();
        public int FieldSize = 50;
        public int Size = 0;

        public void SetMap(string filePath)
        {
            map = File.ReadAllText(filePath).Split('\n').Select(line => line.ToList()).ToList();
            for (int row = 0; row < map.Count; ++row)
            {
                Size = Math.Max(Size, map[row].Count);

                for (int col = 0; col < map[row].Count; ++col)
                {
                    if (map[row][col] == '@')
                    {
                        player.PosX = col;
                        player.PosY = row;
                        player.OldX = col;
                        player.OldY = row;
                        map[row][col] = 'o';
                    }
                }
            }
        }

        public void Resize(object sender, EventArgs args)
        {
            Form form = sender as Form;
            FieldSize = Math.Min(form.Width / Size, (form.Height - 50) / map.Count);
            form.Invalidate();
        }

        public void DrawMap(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Brush redBrush = new SolidBrush(Color.Red);
            Brush blackBruah = new SolidBrush(Color.Black);
            Brush greenBrush = new SolidBrush(Color.Green);
            for (int row = 0; row < map.Count; ++row)
            {
                for (int col = 0; col < map[row].Count; ++col)
                {
                    switch (map[row][col])
                    {
                        case 'o':
                            {
                                e.Graphics.FillEllipse(greenBrush, FieldSize * col, FieldSize * row, FieldSize, FieldSize);
                                break;
                            }
                        case 'x':
                            {
                                e.Graphics.FillEllipse(blackBruah, FieldSize * col, FieldSize * row, FieldSize, FieldSize);
                                break;
                            }
                    }
                }
            }

            UpdateMap(sender, e);
        }

        public void UpdateMap(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Brush redBrush = new SolidBrush(Color.Red);
            Brush greenBrush = new SolidBrush(Color.Green);
            e.Graphics.FillEllipse(greenBrush, FieldSize * player.OldX, FieldSize * player.OldY, FieldSize, FieldSize);
            e.Graphics.FillEllipse(redBrush, FieldSize * player.PosX, FieldSize * player.PosY, FieldSize, FieldSize);
        }

        public void OnLeft(object sender, EventArgs args)
        {
            if (player.PosX > 0 && map[player.PosY][player.PosX - 1] != 'x' && map[player.PosY][player.PosX - 1] != '.')
            {
                player.MoveLeft();
            }
        }

        public void OnRight(object sender, EventArgs args)
        {
            if (player.PosX < map[player.PosY].Count - 1 && map[player.PosY][player.PosX + 1] != 'x' && map[player.PosY][player.PosX + 1] != '.')
            {
                player.MoveRight();
            }
        }

        public void OnUp(object sender, EventArgs args)
        {
            if (player.PosY > 0 && map[player.PosY - 1][player.PosX] != 'x' && map[player.PosY - 1][player.PosX] != '.')
            {
                player.MoveUp();
            }
        }

        public void OnDown(object sender, EventArgs args)
        {
            if (player.PosY < map.Count - 1 && map[player.PosY + 1][player.PosX] != 'x' && map[player.PosY + 1][player.PosX] != '.')
            {
                player.MoveDown();
            }
        }
    }

    internal class Player
    {
        public int PosX { get; set; } = 0;

        public int PosY { get; set; } = 0;

        public int OldX { get; set; } = 0;

        public int OldY { get; set; } = 0;

        public void MoveUp()
        {
            OldY = PosY;
            OldX = PosX;
            PosY--;
        }

        public void MoveDown()
        {
            OldY = PosY;
            OldX = PosX;
            PosY++;
        }

        public void MoveLeft()
        {
            OldY = PosY;
            OldX = PosX;
            PosX--;
        }

        public void MoveRight()
        {
            OldY = PosY;
            OldX = PosX;
            PosX++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MushroomMove
{
    public partial class MoveObject : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        private int x;
        private int y;
        private Position objPos;

        public MoveObject()
        {
            InitializeComponent();

            x = 50;
            y = 50;
            objPos = Position.Down;
        }

        private void MoveObject_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.RoyalBlue, x, y, 64, 64);
            e.Graphics.DrawImage(new Bitmap("Mushroom.png"), x, y, 64, 64);
        }

        private void tmrMushroom_Tick(object sender, EventArgs e)
        {
            if (objPos == Position.Right)
            {
                x += 5;
            }
            else if (objPos == Position.Left)
            {
                x -= 5;
            }
            else if (objPos == Position.Up)
            {
                y -= 5;
            }
            else if (objPos == Position.Down)
            {
                y += 5;
            }
            
            Invalidate();
        }

        private void MoveObject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                objPos = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                objPos = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objPos = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objPos = Position.Down;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectVisualaizer
{
    public partial class PointInRectangleForm : Form
    {
        public PointInRectangleForm()
        {
            InitializeComponent();
        }

        private void buttondraw_Click(object sender, EventArgs e)
        {
            Draw();
        }
        private void Draw()
        {
            var x1 = this.numericUpDownx1.Value;
            var y1 = this.numericUpDowny1.Value;
            var x2 = this.numericUpDownx2.Value;
            var y2 = this.numericUpDowny2.Value;
            var x = this.numericUpDownx.Value;
            var y = this.numericUpDowny.Value;

            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var up = Math.Min(y1, y2);
            var down = Math.Max(y1, y2);

            if (x > left && x < right && y > up && y < down)
            {
                this.labelInside.Text = "Inside";
            }
            else if (x < left || x > right || y < up || y > down)
            {
                this.labelInside.Text = "Outside";
            }
            else if ((x == left || x == right) && (y == up || y == down));
            {
                this.labelInside.Text = "Corner";
            }
            else
              this.labelInside.Text = "Border";

            Visualize
        }

        private void numericUpDownx1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDowny1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownx2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDowny2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void PointInRectangleForm_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

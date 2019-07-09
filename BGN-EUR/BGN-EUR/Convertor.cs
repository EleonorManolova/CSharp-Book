using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGN_EUR
{
    public partial class Convertor : Form
    {
        public Convertor()
        {
            InitializeComponent();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

         void Convert()
        {
            var amount = this.numericUpDownAmount.Value;
            var amountInEuro = amount / 1.95583m;
            this.labelResult.Text = amount + "BGN = " + Math.Round(amountInEuro, 2) + "EUR";
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}

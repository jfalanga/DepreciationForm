using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationForm
{
   
    public partial class Form1 : Form
    {
        string textEnd;
        string textBegin;

        public Form1()
        {
            InitializeComponent();
        }

        private void DigitTextBox(object sender, EventArgs e)
        {
            decimal d = new decimal();
            decimal d2 = new decimal();
            if (!Decimal.TryParse(TxtEnding.Text, out d))
            {
                TxtEnding.Text = textEnd;
                return;
            }
            if (!Decimal.TryParse(TxtStarting.Text,out d2))
            {
                TxtStarting.Text = textBegin;
            }
            CentRound(d, ref TxtEnding);
            CentRound(d2, ref TxtStarting);

            textEnd = TxtEnding.Text;
            textBegin = TxtStarting.Text;

        }

        private void CentRound(decimal moola,ref TextBox textBox)
        {
            decimal rounded = Decimal.Round(moola, 2);
            if (rounded!=moola)
            {
                textBox.Text = rounded.ToString();
            }
        }

        private void DateInventory_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

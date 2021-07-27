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
        List<DepreciationStraightLine> depreciations=new List<DepreciationStraightLine>();

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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DepreciationStraightLine dep = new DepreciationStraightLine();
            try
            {
                
                dep.DateAddedToInventory = DateAdded.Value;
                dep.DateRemovedFromInventory = DateTakingAway.Value;
                dep.StartValue = Decimal.Parse(TxtStarting.Text);

                if (TxtLifetime.Text == "")
                {
                    dep.LifeTime = 0;
                }
                else
                {
                    dep.LifeTime = Int32.Parse(TxtLifetime.Text);
                }
                dep.Title = TxtTitle.Text;
                dep.EndValue = Decimal.Parse(TxtEnding.Text);
            } catch (FormatException)
            {
                MessageBox.Show("There seems to be something wrong with the data for this entry. Are you sure you entered it right?", "Data Error");
            } catch (Exception exp)
            {

                MessageBox.Show("There seems to be a problem: " + exp.Message, "error");
            }
            depreciations.Add(dep);
            LstInventory.DataSource = null;
            LstInventory.DataSource = depreciations;
            
        }

        private void TxtLifetime_TextChanged(object sender, EventArgs e)
        {
            if (TxtLifetime.Text == "") return;
            int ix = new int();
            if (!Int32.TryParse(TxtLifetime.Text, out ix))
            {
                TxtLifetime.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ix = LstInventory.SelectedIndex;
            if (depreciations.Count == 0||ix==-1) return;
            depreciations.RemoveAt(ix);
            LstInventory.DataSource = null;
            LstInventory.DataSource = depreciations;
        }
    }
}

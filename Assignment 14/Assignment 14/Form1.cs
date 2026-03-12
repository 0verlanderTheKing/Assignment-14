using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startingBalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndingBalenceLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal interestRate = 0.005m;

            decimal balance;
            int months;
            int count = 1;

            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    while (count <= months)
                    {
                        balance = balance + (interestRate * balance);
                        count = count + 1;

                        
                    }
                    EndingBalenceLabel.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("Invalid value for months.");
                }
                

                
                
            }
            else
            {
                MessageBox.Show("Invalid value for starting balence.");
            }
        }

    


        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labels
{
    public partial class Form1 : Form
    {
        double hours;
        double pay;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(hoursText.Text) || !string.IsNullOrEmpty(payText.Text))
            {
                hours = double.Parse(hoursText.Text);
                pay = double.Parse(payText.Text);

                MessageBox.Show("You made $" + (hours * pay) + " this pay period.");
            } else
            {
                MessageBox.Show("Please enter the correct information");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

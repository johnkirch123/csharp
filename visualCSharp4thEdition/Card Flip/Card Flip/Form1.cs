using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cardBackImage.Hide();
            cardFrontImage.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            cardBackImage.Visible = true;
            cardFrontImage.Hide();
        }

        private void faceButton_Click(object sender, EventArgs e)
        {
            cardBackImage.Hide();
            cardFrontImage.Show();
        }
    }
}

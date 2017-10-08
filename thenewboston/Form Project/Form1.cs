using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "John Kirch";
            int number = 37;
            bool old = true;
            object myObject = MessageBox.Show(name);
            MessageBox.Show(old.ToString(), number.ToString());
            MessageBox.Show(myObject.ToString());
        }
    }
}

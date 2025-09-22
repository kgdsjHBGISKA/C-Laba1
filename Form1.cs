using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LB1_LARINM_ADB_23_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drowBox1.X1 = int.Parse(textBoxX1.Text);
            drowBox1.X2 = int.Parse(textBoxX2.Text);
            drowBox1.Y1 = int.Parse(textBoxY1.Text);
            drowBox1.Y2 = int.Parse(textBoxY2.Text);

            drowBox1.Invalidate();
        }

        private void drowBox1_Load(object sender, EventArgs e)
        {

        }
    }
}

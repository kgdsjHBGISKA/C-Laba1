using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_LARINM_ADB_23_06
{
    public partial class DrowBox : UserControl
    {
        public DrowBox()
        {
            InitializeComponent();
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Blue, x1, y1, x2, y2);
        }

        private int x1 = 10;
        private int y1 = 10;
        private int x2 = 100;
        private int y2 = 75;

        public int X1
        {
            set { x1 = value; }
        }
        public int Y1
        {
            set { y1 = value; }
        }
        public int X2
        {
            set { x2 = value; }
        }
        public int Y2
        {
            set { y2 = value; }
        }
    }
}

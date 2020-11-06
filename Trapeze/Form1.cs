using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trapeze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.BlueViolet, 5);
            Point[] a = { new Point(100, 400), new Point(200, 100), new Point(400, 100), new Point(00, 400) };
            l.DrawPolygon(p, a);
            l.Dispose();
        }
    }
}

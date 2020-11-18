using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графіки_функцій
{
    public partial class trapeze : Form
    {
        public trapeze()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            Rectangle rect = new Rectangle(0, 0, 200, 200);

            Point[] points = new Point[4];
            points[0] = new Point(100, 300);
            points[1] = new Point(200, 00);
            points[2] = new Point(400, 00);
            points[3] = new Point(500, 300);

            e.Graphics.DrawPolygon(blackPen, points);
        }
    }
}

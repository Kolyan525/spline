using System;
using System.Windows.Forms;

namespace Графіки_функцій
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "-6,28"; textBox2.Text = "6,28"; textBox3.Text = "0,1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text), b = double.Parse(textBox2.Text), h = double.Parse(textBox3.Text), x, y;
            if (checkBox1.Checked)
            {
                this.chart1.Series[0].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x) + Math.Cos(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (checkBox2.Checked)
            {
                this.chart1.Series[1].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Cos(x);
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (checkBox3.Checked)
            {
                this.chart1.Series[2].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[2].Points.AddXY(x, y);
                    x += h;
                }
            }
            else if(!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Виберіть графік для побудови!", "Не вибраний графік для побудови", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart1.Series[2].Points.Clear();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked)
            //{
            //    double a = double.Parse(textBox1.Text), b = double.Parse(textBox2.Text), h = double.Parse(textBox3.Text), x, y;
            //    this.chart1.Series[1].Points.Clear();
            //    x = a;
            //    while (x <= b)
            //    {
            //        y = Math.Cos(x);
            //        this.chart1.Series[1].Points.AddXY(x, y);
            //        x += h;
            //    }
            //}
            //else
            //    this.chart1.Series[1].Points.Clear();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox3.Checked)
            //{
            //    double a = double.Parse(textBox1.Text), b = double.Parse(textBox2.Text), h = double.Parse(textBox3.Text), x, y;
            //    this.chart1.Series[2].Points.Clear();
            //    x = a;
            //    while (x <= b)
            //    {
            //        y = Math.Sin(x);
            //        this.chart1.Series[2].Points.AddXY(x, y);
            //        x += h;
            //    }
            //}
            //else
            //    this.chart1.Series[2].Points.Clear();
        }
    }
}

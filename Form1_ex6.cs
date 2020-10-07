using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangles;
namespace Дз4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            label4.Text = "";
        }


        private Triangle NewT()
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int angleAB = int.Parse(textBox3.Text);
            int side3 = (int)Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleAB*Math.PI/180));
            if (a == side3 || b == side3 || a == b)
            {
                return new IsoscelesTriangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
            }
            else
            {
                return new RightTriangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((double.Parse(textBox3.Text) < 180 && double.Parse(textBox3.Text) > 0) && (double.Parse(textBox1.Text) > 0 && double.Parse(textBox2.Text)>0))
            {
                label4.Text = "Трикутник добавлений";
            }
            else
            {
                label4.Text = "Трикутник не існує";
                return;
            }

            int id = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add();

            Triangle tr = NewT();
            dataGridView1.Rows[id].Cells[0].Value = tr.GetTriangleName();
            dataGridView1.Rows[id].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[id].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[id].Cells[3].Value = textBox3.Text;
            dataGridView1.Rows[id].Cells[4].Value = tr.Perimeter();
            dataGridView1.Rows[id].Cells[5].Value = tr.Area();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            if (char.IsControl(e.KeyChar))
            {

                if ((e.KeyChar) == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                    {
                        textBox2.Focus();
                    }
                    else
                    {
                        button1.Focus();
                    }
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if ((textBox2.Text.IndexOf(',') != -1) || (textBox2.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            if (char.IsControl(e.KeyChar))
            {

                if ((e.KeyChar) == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox2))
                    {
                        textBox3.Focus();
                    }
                    else
                    {
                        button1.Focus();
                    }
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if ((textBox3.Text.IndexOf(',') != -1) || (textBox3.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (char.IsControl(e.KeyChar))
            {

                if ((e.KeyChar) == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox3))
                    {
                        button1.Focus();
                    }

                }
                return;
            }
            e.Handled = true;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}

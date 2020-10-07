using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trg;
namespace ДЗ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool TCheck(string a, string b, string c)
        {
            double side1 = double.Parse(a);
            double side2 = double.Parse(b);
            double side3 = double.Parse(c);
            if ((side1 > 0 && side2 > 0 && side3 > 0) && ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2)))
            {
                return true;
            }
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TCheck(textBox1.Text, textBox2.Text, textBox3.Text)) 
            {
                label4.Text = "Трикутник добавлений";
            }
            else
            {
                label4.Text = "Трикутник не існує";
                return;
            }

            int id = dataGridView1.Rows.Count-1;
            dataGridView1.Rows.Add();
           
            if (textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text)
            {
                EquilateralTriangle tr = new EquilateralTriangle(double.Parse(textBox1.Text));
                dataGridView1.Rows[id].Cells[0].Value = "Рівносторонній Трикутник";
                dataGridView1.Rows[id].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[id].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[id].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[id].Cells[4].Value = tr.GetAngleS12();
                dataGridView1.Rows[id].Cells[5].Value = tr.GetAngleS13();
                dataGridView1.Rows[id].Cells[6].Value = tr.GetAngleS23();
                dataGridView1.Rows[id].Cells[7].Value = tr.GetPerimeter();
                dataGridView1.Rows[id].Cells[8].Value = tr.GetArea();
            }
            else
            {
                Triangle tr = new Triangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                dataGridView1.Rows[id].Cells[0].Value = "Трикутник";
                dataGridView1.Rows[id].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[id].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[id].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[id].Cells[4].Value = tr.GetAngleS12();
                dataGridView1.Rows[id].Cells[5].Value = tr.GetAngleS13();
                dataGridView1.Rows[id].Cells[6].Value = tr.GetAngleS23();
                dataGridView1.Rows[id].Cells[7].Value = tr.GetPerimeter();
                dataGridView1.Rows[id].Cells[8].Value = "Unknown";
            }
            
            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar<='9')
            {
                return;
            }
            if(e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if(e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            if(char.IsControl(e.KeyChar))
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
                if ((textBox3.Text.IndexOf(',') != -1) ||(textBox3.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            
            if (char.IsControl(e.KeyChar))
            {

                if ((e.KeyChar) == (char)Keys.Enter )
                {
                    if(sender.Equals(textBox3))
                    {
                        button1.Focus();
                    }
                    
                }
                return;
            }
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 )
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

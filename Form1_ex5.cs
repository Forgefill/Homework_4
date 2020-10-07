using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;
namespace Дз4_6
{
    public partial class Form1 : Form
    {
        List<Figure> figures = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddToDGV(Figure f)
        {
            figures.Add(f);
            int id = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[id].Cells[0].Value = f.GetFigureType();
            dataGridView1.Rows[id].Cells[1].Value = f.Perimeter();
            dataGridView1.Rows[id].Cells[2].Value = f.Area();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Figure f = new Triangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
            AddToDGV(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figure f = new Circle(double.Parse(textBox4.Text));
            AddToDGV(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Figure f = new Figures.Rectangle(double.Parse(textBox5.Text), double.Parse(textBox6.Text));
            AddToDGV(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Figure f = new Square(double.Parse(textBox7.Text));
            AddToDGV(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Figure f = new Rhombus(double.Parse(textBox8.Text), double.Parse(textBox9.Text));
            AddToDGV(f);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

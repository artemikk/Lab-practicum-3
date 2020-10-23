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
        List<student> studGroup = new List<student>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            student a1 = new student(111, "Иванов Саша");
            student a2 = new student(222, "Петров Витя");
            student a3 = new student(333, "Васильева Юля");
            student a4 = new student(444, "Гришин Костя");
            studGroup.Add(a1);
            studGroup.Add(a2);
            studGroup.Add(a3);
            studGroup.Add(a4);

            listBox1.DisplayMember = "name";  // будет показываться свойство Name
            listBox1.ValueMember = "id";  // Будет возвращаться значение свойства ID
            listBox1.DataSource = studGroup;  // задана коллекция

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                int n = listBox1.SelectedIndex;
                double b = (double)listBox1.SelectedValue;
                MessageBox.Show("ID студента = " + b.ToString());
        }
    }
}

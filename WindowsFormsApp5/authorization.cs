using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "123";
            string password = "123";

            if (textBox1.Text == login & textBox2.Text == password)
            {
                Form1 f = new Form1();
                f.Show();
            }
            else
                MessageBox.Show("Не верно \nПопробуйте еще");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

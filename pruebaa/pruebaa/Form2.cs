using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaa
{
    public partial class Form2 : Form
    {
        string _n;
        public Form2(string n)
        {
            InitializeComponent();
            _n = n;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _n;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
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
    public partial class Form3 : Form
    {
        PictureBox[] pictureBoxesArray = new PictureBox[3];
        Image[] posiblesemociones = new Image[3];
     
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            posiblesemociones[0] = pruebaa.Properties.Resources.pictocont;
            posiblesemociones[1] = pruebaa.Properties.Resources.pictoenojo;
            pictureBoxesArray[1].Image = posiblesemociones[0];
        }
    }
}

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
  
        PictureBox[] pictureBoxesArray = new PictureBox[4];
        Image[] posiblesEmociones = new Image[3];
        Random numEmocion = new Random();


        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            posiblesEmociones[0] = pruebaa.Properties.Resources.pictocont;
            posiblesEmociones[1] = pruebaa.Properties.Resources.pictoenojo;
            posiblesEmociones[2] = pruebaa.Properties.Resources.pictotriste;
            pictureBoxesArray[0].Image = posiblesEmociones[(numEmocion.Next(0, 2) + 1)];
            pictureBoxesArray[1].Image = posiblesEmociones[(numEmocion.Next(0, 2) + 1)];
            pictureBoxesArray[2].Image = posiblesEmociones[(numEmocion.Next(0, 2) + 1)];
            pictureBoxesArray[3].Image = posiblesEmociones[(numEmocion.Next(0, 2) + 1)];

  
            
           
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            pictureBoxesArray[0].Show();
        }
    }
}

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
 //creo array para guardar las fotos de abajo, array con las 3 fotos y un random que despues uso para asignar las fotos a los pBox
        PictureBox[] pictureBoxesArray = new PictureBox[3];
        Image[] posiblesEmociones = new Image[3];
        Random numEmocion = new Random();
        

        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
 //agrego los pBox que cree por pantalla al array pictureBoxesArray
           
            pictureBoxesArray[0] = pB2;
            pictureBoxesArray[1] = pB3;
            pictureBoxesArray[2] = pB4;

 //Esto es una funcion para que las imagenes se vean centradas en el pBox
            for (int i = 0; i < pictureBoxesArray.Length; i++)
            {  
                pictureBoxesArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;
 //Cargo la imagen de la compu y las meto en el array      
            posiblesEmociones[0] = pruebaa.Properties.Resources.pictocont;
            posiblesEmociones[1] = pruebaa.Properties.Resources.pictoenojo;
            posiblesEmociones[2] = pruebaa.Properties.Resources.pictotriste;
            //Asigno una emocion a cada pBox aleatoriamente

            pB1.Image = posiblesEmociones[(numEmocion.Next(0, 2) + 1)];

            for(int i = 0; i<pictureBoxesArray.Length; i++){
                pictureBoxesArray[i].Image = posiblesEmociones[(numEmocion.Next(0, 2) + 1)];
            }
         
        }


        private void btnstart_Click(object sender, EventArgs e)
        {
            
        }
    }
}

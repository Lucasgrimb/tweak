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
        List <Image> posiblesEmociones = new List<Image>();
        List <int> numEmocion = new List<int> ();
        
        Random raux = new Random();

        

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
            for (int x = 0; x < pictureBoxesArray.Length; x++)
            {
                pictureBoxesArray[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Cargo la imagen de la compu y las meto en el array      
            posiblesEmociones.Add(pruebaa.Properties.Resources.pictocont);
            posiblesEmociones.Add(  pruebaa.Properties.Resources.pictoenojo);
            posiblesEmociones.Add( pruebaa.Properties.Resources.pictotriste);


  
            //Asigno una emocion a cada pBox aleatoriamente
            int contador = 0;
            while (posiblesEmociones.Count > 0)
            {
                int i = raux.Next(0, posiblesEmociones.Count);
                pictureBoxesArray[contador].Image = posiblesEmociones[i];
                posiblesEmociones.RemoveAt(i);
                contador++;
            }
            //Asigno emocion a Pb1
            pB1.Image = pictureBoxesArray[raux.Next(0, pictureBoxesArray.Length)].Image;



         
}
        private void btnstart_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

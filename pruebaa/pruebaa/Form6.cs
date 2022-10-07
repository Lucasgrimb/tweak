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
    public partial class Form6 : Form
    {
        PictureBox[] pBpictos = new PictureBox[3];
        PictureBox[] pBdibujos = new PictureBox[3];
        List<Image> pictos = new List<Image>();
        List<Image> dibujos = new List<Image>();
        Random rand = new Random();
      
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //agrego Pb al arrray
            pBpictos[0] = pB1p;
            pBpictos[1] = pB2p;
            pBpictos[2] = pB3p;

            pBdibujos[0] = pB1p;
            pBdibujos[1] = pB2p;
            pBdibujos[2] = pB3p;

            // pongo las imagenes en un formato especial para que se vean centradas

            for (int x = 0; x < pBpictos.Length; x++)
            {
                pBpictos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int x = 0; x < pBdibujos.Length; x++)
            {
                pBdibujos[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }

            randomizarImagenes();
            

            

        }
        private void randomizarImagenes()
        {
            // Agrego las imagenes de resources a la lista con las emociones que se usarán en el nivel
            pictos.Add(pruebaa.Properties.Resources.contento);
            pictos.Add(pruebaa.Properties.Resources.triste);
            pictos.Add(pruebaa.Properties.Resources.enfadado);
            pictos.Add(pruebaa.Properties.Resources.asustado);
            pictos.Add(pruebaa.Properties.Resources.sorprendido);
            pictos.Add(pruebaa.Properties.Resources.cansado);
            pictos.Add(pruebaa.Properties.Resources.hambriento);
            pictos.Add(pruebaa.Properties.Resources.sediento);
            pictos.Add(pruebaa.Properties.Resources.enfermo);
            pictos.Add(pruebaa.Properties.Resources.aburrido);
            pictos.Add(pruebaa.Properties.Resources.preocupado);

            dibujos.Add(pruebaa.Properties.Resources.contentoD);
            dibujos.Add(pruebaa.Properties.Resources.tristeD);
            dibujos.Add(pruebaa.Properties.Resources.enfadadoD);
            dibujos.Add(pruebaa.Properties.Resources.asustadoD);
            dibujos.Add(pruebaa.Properties.Resources.sorprendidoD);
            dibujos.Add(pruebaa.Properties.Resources.cansadoD);
            dibujos.Add(pruebaa.Properties.Resources.hambrientoD);
            dibujos.Add(pruebaa.Properties.Resources.sedientoD);
            dibujos.Add(pruebaa.Properties.Resources.enfermoD);
            dibujos.Add(pruebaa.Properties.Resources.aburridoD);
            dibujos.Add(pruebaa.Properties.Resources.preocupadoD);

            //asigno emociones a pBpictos
           

            for (int i = 0; i < 3; i++)
            {
                int x = rand.Next(0, pictos.Count);

                pBpictos [i].Image = pictos[x];
                pictos.RemoveAt(x);         
                pBdibujos[i].Image = dibujos[x];
                dibujos.RemoveAt(x);
       

            }





            
        }
    }
}

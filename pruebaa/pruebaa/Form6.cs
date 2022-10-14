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
        List<Image> ndibujos = new List<Image>();
        Random rand = new Random();
        String aux;
        int cont = 0;
 
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

            pBdibujos[0] = pB1d;
            pBdibujos[1] = pB2d;
            pBdibujos[2] = pB3d;
           
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

            pictos[0].Tag = "contento";
            pictos[1].Tag = "triste";
            pictos[2].Tag = "enfadado";
            pictos[3].Tag = "asustado";
            pictos[4].Tag = "sorprendido";
            pictos[5].Tag = "cansado";
            pictos[6].Tag = "hambriento";
            pictos[7].Tag = "sediento";
            pictos[8].Tag = "enfermo";
            pictos[9].Tag = "aburrido";
            pictos[10].Tag = "preocupado";


            dibujos[0].Tag = "contento";
            dibujos[1].Tag = "triste";
            dibujos[2].Tag = "enfadado";
            dibujos[3].Tag = "asustado";
            dibujos[4].Tag = "sorprendido";
            dibujos[5].Tag = "cansado";
            dibujos[6].Tag = "hambriento";
            dibujos[7].Tag = "sediento";
            dibujos[8].Tag = "enfermo";
            dibujos[9].Tag = "aburrido";
            dibujos[10].Tag = "preocupado";


            //asigno emociones a pBpictos

            for (int i = 0; i < 3; i++)
            {               
                int x = rand.Next(0, pictos.Count);
             
                pBpictos [i].Image = pictos[x];
                pBpictos[i].Tag = i.ToString();
                ndibujos.Add(dibujos[x]);
                pictos.RemoveAt(x);        
                dibujos.RemoveAt(x);                          
            }
            for (int j = 0; j<3; j++)
            {
                int f = rand.Next(0, ndibujos.Count);
                pBdibujos[j].Image = ndibujos[f];
                ndibujos.RemoveAt(f);
            }
        
        }

        private void pB1p_Click(object sender, EventArgs e)
        {
            aux = pB1p.Image.Tag.ToString();
        }

        private void pB2p_Click(object sender, EventArgs e)
        {
            aux = pB2p.Image.Tag.ToString();
        }

        private void pB3p_Click(object sender, EventArgs e)
        {
            aux = pB3p.Image.Tag.ToString();
        }

        private void pB1d_Click(object sender, EventArgs e)
        {
            if (pB1d.Image.Tag.ToString() == aux)
            {
                MessageBox.Show("Correcto");
                cont++;
            }
            else
            {
                MessageBox.Show("incorrecto, volve a intentarlo");
            }
        }

        private void pB2d_Click(object sender, EventArgs e)
        {
            if (pB2d.Image.Tag.ToString() == aux)
            {
                MessageBox.Show("Correcto");
                cont++;
            }
            else
            {
                MessageBox.Show("incorrecto, volve a intentarlo");
            }
        }

        private void pB3d_Click(object sender, EventArgs e)
        {
            if (pB3d.Image.Tag.ToString() == aux)
            {
                MessageBox.Show("Correcto");
                cont++;
            }
            else
            {
                MessageBox.Show("incorrecto, volve a intentarlo");
            }
        }
    }
}

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
        List<Image> posiblesEmociones = new List<Image>();
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
            pBdibujos[0] = pB1d;
            pBdibujos[1] = pB2d;
            pBdibujos[2] = pB3d;
        }
    }
}

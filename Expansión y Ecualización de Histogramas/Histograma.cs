using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expansión_y_Ecualización_de_Histogramas
{
    public partial class Histograma : Form
    {

        private int[] histograma;
        private int mayor;


        public Histograma(int[] pHistograma)
        {
            InitializeComponent();
            histograma = pHistograma;
            mayor = 0;

            for (int i = 0; i < 256; i++)
                if (histograma[i] > mayor)
                    mayor = histograma[i];

            for (int i = 0; i < 256; i++)
            {
                histograma[i] = (int)((float)histograma[i] / (float)mayor * 256.0f);
            }
        }

        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen LapizHistograma = new Pen(Color.Black);
            Pen LapizEjes = new Pen(Color.Coral);

            g.DrawLine(LapizEjes, 19, 271, 277, 271);
            g.DrawLine(LapizEjes, 19, 270, 19, 14);

            for (int i = 0; i < 256; i++)
            {
                g.DrawLine(LapizHistograma, i + 20, 270, i + 20, 270 - histograma[i]);
            }

        }
    }
}


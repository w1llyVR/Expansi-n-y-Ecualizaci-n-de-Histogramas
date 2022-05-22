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
    public partial class HistoForm : Form
    {

        private int[] histograma;
        private int mayor;

        public HistoForm(int [] pHistograma)
        {
            InitializeComponent();
            histograma = pHistograma;
            int n = 0;

            //Encontramos el mayor
            mayor = 0;
            for (int i = 0; i < 256; i++)
            {
                if(histograma[i] > mayor)
                {
                    mayor = histograma[i];
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histograma[n] = (int)((float)histograma[n] / (float)mayor * 256.0f);
            }
        }

        private void HistoForm_Paint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen plumaH = new Pen(Color.Black);
            Pen plumaEjes = new Pen(Color.Coral);

            g.DrawLine(plumaEjes, 19, 271, 277, 271);
            g.DrawLine(plumaEjes, 19, 270, 19, 14);

            for (int i = 0; i < 256; i++)
            {
                g.DrawLine(plumaH, i + 20, 270, i + 20, 270 - histograma[i]);
            }
        }
    }
}


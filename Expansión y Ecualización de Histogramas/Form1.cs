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
    public partial class Form1 : Form
    {
        private Bitmap original;
        private Bitmap resultado;
        private int[] histograma = new int[256];
        private int anchoV, altoV;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoV = original.Width;
                anchoV = original.Height;
                resultado = original;
                this.Invalidate();
            }
        }

        private void salvarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultado.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(resultado != null)
            {
                Graphics g = e.Graphics;
                AutoScrollMinSize = new Size(anchoV, altoV);
                g.DrawImage(resultado, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 30, anchoV, altoV));
                g.Dispose();
            }
        }

        private void histogramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void ecualizarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Color pixelColor = new Color();

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    pixelColor = original.GetPixel(i, j);
                    histograma[pixelColor.R]++;
                }
            }
            Histograma histogramaForm = new Histograma(histograma);
            int cOriginal = 0;
            int suma = 0;
            int[] suma_histograma = new int[256];

            int tono = 0;
            Color miColor;

            double constante = 0;

            for (int i = 0; i < 255; i++)
            {
                suma += histograma[i];
                suma_histograma[i] = suma;
            }

            constante = (double)(suma) / (double)(original.Width * original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    cOriginal = original.GetPixel(i, j).R;

                    tono = (int)((double)suma_histograma[cOriginal] * constante);
                    if (tono > 255) tono = 255;

                    miColor = Color.FromArgb(tono, tono, tono);
                    resultado.SetPixel(i, j, miColor);

                }
            }

            this.Invalidate();
        }

        private void expandirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultado = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            float g = 0;
            int minR = original.GetPixel(0,0).R, maxR = original.GetPixel(0, 0).R;
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    if (original.GetPixel(i, j).R > maxR) maxR = original.GetPixel(i, j).R;
                    if (original.GetPixel(i, j).R < minR) minR = original.GetPixel(i, j).R;
                }
            }
            if (minR == 0) minR = 1;
            float pendiente = (300 - 100) / (maxR - minR);
            if (pendiente < 1) pendiente = 1;
            float b = 300 - (maxR * pendiente);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    g = ((pendiente * original.GetPixel(i, j).R) + b) * 0.110f + ((pendiente * original.GetPixel(i, j).R) + b) * 0.110f + ((pendiente * original.GetPixel(i, j).R) + b) * 0.110f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    resultado.SetPixel(i, j, rColor);
                }
            }
            this.Invalidate();
        }

        private void histogramaGrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color rColor = new Color();
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    // Obtenemos el color del pixel
                    rColor = resultado.GetPixel(i, j);
                    histograma[rColor.R]++;
                }
            }

            //Histograma hform = new Histograma(histograma);
            //hform.Show();

     

            int[] hs = new int[256];
            hs[0] = (histograma[0] + histograma[1]) / 2;
            hs[255] = (histograma[255] + histograma[254]) / 2;
            for (int i = 1; i < 254; i++)
            {
                hs[i] = (histograma[i - 1] + histograma[i] + histograma[i + 1]) / 3;
            }

            Histograma hsform = new Histograma(hs);
            hsform.Show();
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixelColor = new Color();
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    pixelColor = original.GetPixel(i, j);
                    histograma[pixelColor.R]++;
                }
            }

            Histograma histogramaForm = new Histograma(histograma);
            histogramaForm.Show();
        }

        public Form1()
        {
            resultado = new Bitmap(900, 700);

            anchoV = 800;
            altoV = 600;

        
            InitializeComponent();
        }
    }
}

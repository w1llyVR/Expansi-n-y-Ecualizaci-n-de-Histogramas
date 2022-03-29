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
        private int[,] conversion3p3 = new int[3, 3];
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

        public Form1()
        {
            resultado = new Bitmap(900, 700);

            anchoV = 800;
            altoV = 600;

        
            InitializeComponent();
        }
    }
}


namespace Expansión_y_Ecualización_de_Histogramas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.básicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecualizarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.básicosToolStripMenuItem,
            this.histogramasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(984, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.salvarImagenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir Imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // salvarImagenToolStripMenuItem
            // 
            this.salvarImagenToolStripMenuItem.Name = "salvarImagenToolStripMenuItem";
            this.salvarImagenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salvarImagenToolStripMenuItem.Text = "Salvar Imagen";
            this.salvarImagenToolStripMenuItem.Click += new System.EventHandler(this.salvarImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // básicosToolStripMenuItem
            // 
            this.básicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandirImagenToolStripMenuItem,
            this.ecualizarImagenToolStripMenuItem});
            this.básicosToolStripMenuItem.Name = "básicosToolStripMenuItem";
            this.básicosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.básicosToolStripMenuItem.Text = "Básicos";
            // 
            // expandirImagenToolStripMenuItem
            // 
            this.expandirImagenToolStripMenuItem.Name = "expandirImagenToolStripMenuItem";
            this.expandirImagenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.expandirImagenToolStripMenuItem.Text = "Expandir Imagen";
            // 
            // ecualizarImagenToolStripMenuItem
            // 
            this.ecualizarImagenToolStripMenuItem.Name = "ecualizarImagenToolStripMenuItem";
            this.ecualizarImagenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ecualizarImagenToolStripMenuItem.Text = "Ecualizar Imagen";
            // 
            // histogramasToolStripMenuItem
            // 
            this.histogramasToolStripMenuItem.Name = "histogramasToolStripMenuItem";
            this.histogramasToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.histogramasToolStripMenuItem.Text = "Histogramas";
            this.histogramasToolStripMenuItem.Click += new System.EventHandler(this.histogramasToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagenes PNG|*.png|Imagenes Bitmap|*.bmp|Imagenes JPG|*.jpg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(984, 609);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem básicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecualizarImagenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


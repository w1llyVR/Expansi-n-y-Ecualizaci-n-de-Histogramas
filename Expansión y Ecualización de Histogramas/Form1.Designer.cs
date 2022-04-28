
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaGrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.básicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecualizarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.histogramasToolStripMenuItem,
            this.básicosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.salvarImagenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            resources.ApplyResources(this.abrirImagenToolStripMenuItem, "abrirImagenToolStripMenuItem");
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // salvarImagenToolStripMenuItem
            // 
            this.salvarImagenToolStripMenuItem.Name = "salvarImagenToolStripMenuItem";
            resources.ApplyResources(this.salvarImagenToolStripMenuItem, "salvarImagenToolStripMenuItem");
            this.salvarImagenToolStripMenuItem.Click += new System.EventHandler(this.salvarImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // histogramasToolStripMenuItem
            // 
            this.histogramasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramaGrisToolStripMenuItem,
            this.histogramaToolStripMenuItem});
            this.histogramasToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.histogramasToolStripMenuItem.Name = "histogramasToolStripMenuItem";
            resources.ApplyResources(this.histogramasToolStripMenuItem, "histogramasToolStripMenuItem");
            this.histogramasToolStripMenuItem.Click += new System.EventHandler(this.histogramasToolStripMenuItem_Click);
            // 
            // histogramaGrisToolStripMenuItem
            // 
            this.histogramaGrisToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.histogramaGrisToolStripMenuItem.Name = "histogramaGrisToolStripMenuItem";
            resources.ApplyResources(this.histogramaGrisToolStripMenuItem, "histogramaGrisToolStripMenuItem");
            this.histogramaGrisToolStripMenuItem.Click += new System.EventHandler(this.histogramaGrisToolStripMenuItem_Click);
            // 
            // básicosToolStripMenuItem
            // 
            this.básicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandirImagenToolStripMenuItem,
            this.ecualizarImagenToolStripMenuItem});
            this.básicosToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.básicosToolStripMenuItem.Name = "básicosToolStripMenuItem";
            resources.ApplyResources(this.básicosToolStripMenuItem, "básicosToolStripMenuItem");
            // 
            // expandirImagenToolStripMenuItem
            // 
            this.expandirImagenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.expandirImagenToolStripMenuItem.Name = "expandirImagenToolStripMenuItem";
            resources.ApplyResources(this.expandirImagenToolStripMenuItem, "expandirImagenToolStripMenuItem");
            this.expandirImagenToolStripMenuItem.Click += new System.EventHandler(this.expandirImagenToolStripMenuItem_Click);
            // 
            // ecualizarImagenToolStripMenuItem
            // 
            this.ecualizarImagenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ecualizarImagenToolStripMenuItem.Name = "ecualizarImagenToolStripMenuItem";
            resources.ApplyResources(this.ecualizarImagenToolStripMenuItem, "ecualizarImagenToolStripMenuItem");
            this.ecualizarImagenToolStripMenuItem.Click += new System.EventHandler(this.ecualizarImagenToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            resources.ApplyResources(this.histogramaToolStripMenuItem, "histogramaToolStripMenuItem");
            this.histogramaToolStripMenuItem.Click += new System.EventHandler(this.histogramaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem histogramaGrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
    }
}


namespace ProjetoMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarProduto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdicionarProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 622);
            this.panel1.TabIndex = 0;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdicionarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarProduto.BorderRadius = 0;
            this.btnAdicionarProduto.ButtonText = "bunifuFlatButton1";
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdicionarProduto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Iconimage")));
            this.btnAdicionarProduto.Iconimage_right = null;
            this.btnAdicionarProduto.Iconimage_right_Selected = null;
            this.btnAdicionarProduto.Iconimage_Selected = null;
            this.btnAdicionarProduto.IconMarginLeft = 0;
            this.btnAdicionarProduto.IconMarginRight = 0;
            this.btnAdicionarProduto.IconRightVisible = true;
            this.btnAdicionarProduto.IconRightZoom = 0D;
            this.btnAdicionarProduto.IconVisible = true;
            this.btnAdicionarProduto.IconZoom = 90D;
            this.btnAdicionarProduto.IsTab = false;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(12, 185);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdicionarProduto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdicionarProduto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.selected = false;
            this.btnAdicionarProduto.Size = new System.Drawing.Size(199, 48);
            this.btnAdicionarProduto.TabIndex = 0;
            this.btnAdicionarProduto.Text = "bunifuFlatButton1";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProduto.Textcolor = System.Drawing.Color.White;
            this.btnAdicionarProduto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 162);
            this.panel2.TabIndex = 1;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(210, 162);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(861, 460);
            this.pnPrincipal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 622);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdicionarProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnPrincipal;
    }
}


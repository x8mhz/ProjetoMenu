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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShowProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnShowProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 580);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(37)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(63, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROJETO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(37)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(80, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Relatório";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(14, 293);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(203, 50);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "     Relatório";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.DarkGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "     Sair";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 45D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(14, 490);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(203, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "     Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.DarkGray;
            this.btnExit.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowProduct
            // 
            this.btnShowProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnShowProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnShowProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowProduct.BorderRadius = 0;
            this.btnShowProduct.ButtonText = "     Mostrar";
            this.btnShowProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowProduct.Iconimage")));
            this.btnShowProduct.Iconimage_right = null;
            this.btnShowProduct.Iconimage_right_Selected = null;
            this.btnShowProduct.Iconimage_Selected = null;
            this.btnShowProduct.IconMarginLeft = 0;
            this.btnShowProduct.IconMarginRight = 0;
            this.btnShowProduct.IconRightVisible = true;
            this.btnShowProduct.IconRightZoom = 0D;
            this.btnShowProduct.IconVisible = true;
            this.btnShowProduct.IconZoom = 45D;
            this.btnShowProduct.IsTab = false;
            this.btnShowProduct.Location = new System.Drawing.Point(14, 181);
            this.btnShowProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowProduct.Name = "btnShowProduct";
            this.btnShowProduct.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShowProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnShowProduct.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnShowProduct.selected = false;
            this.btnShowProduct.Size = new System.Drawing.Size(203, 50);
            this.btnShowProduct.TabIndex = 1;
            this.btnShowProduct.Text = "     Mostrar";
            this.btnShowProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowProduct.Textcolor = System.Drawing.Color.DarkGray;
            this.btnShowProduct.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProduct.Click += new System.EventHandler(this.btnShowProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BorderRadius = 0;
            this.btnAddProduct.ButtonText = "     Adicionar";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Iconimage")));
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = true;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = true;
            this.btnAddProduct.IconZoom = 45D;
            this.btnAddProduct.IsTab = false;
            this.btnAddProduct.Location = new System.Drawing.Point(14, 237);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(203, 50);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "     Adicionar";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Textcolor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(216, 121);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(818, 459);
            this.pnPrincipal.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 121);
            this.panel2.TabIndex = 3;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pictureBox1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.label1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.label2;
            this.bunifuDragControl4.Vertical = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(19, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 33);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.text = "Pesquisar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 580);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private System.Windows.Forms.Panel pnPrincipal;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
    }
}


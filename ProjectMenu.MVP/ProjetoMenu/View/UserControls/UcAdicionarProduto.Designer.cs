namespace ProjetoMenu.View.UserControls
{
    partial class UcAdicionarProduto
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAdicionarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtModelo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtQuantidade = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSalvarProduto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLimparCampo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtValor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(60, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(74, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label4.Location = new System.Drawing.Point(40, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.HintForeColor = System.Drawing.Color.Empty;
            this.txtMarca.HintText = "";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMarca.LineThickness = 3;
            this.txtMarca.Location = new System.Drawing.Point(210, 28);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(414, 33);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtModelo
            // 
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModelo.HintForeColor = System.Drawing.Color.Empty;
            this.txtModelo.HintText = "";
            this.txtModelo.isPassword = false;
            this.txtModelo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtModelo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtModelo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtModelo.LineThickness = 3;
            this.txtModelo.Location = new System.Drawing.Point(210, 107);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(414, 33);
            this.txtModelo.TabIndex = 5;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.HintForeColor = System.Drawing.Color.Empty;
            this.txtTipo.HintText = "";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTipo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTipo.LineThickness = 3;
            this.txtTipo.Location = new System.Drawing.Point(210, 187);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(414, 33);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantidade.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantidade.HintText = "";
            this.txtQuantidade.isPassword = false;
            this.txtQuantidade.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantidade.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantidade.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantidade.LineThickness = 3;
            this.txtQuantidade.Location = new System.Drawing.Point(210, 271);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(186, 33);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarProduto.BorderRadius = 0;
            this.btnSalvarProduto.ButtonText = "bunifuFlatButton1";
            this.btnSalvarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProduto.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvarProduto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvarProduto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalvarProduto.Iconimage")));
            this.btnSalvarProduto.Iconimage_right = null;
            this.btnSalvarProduto.Iconimage_right_Selected = null;
            this.btnSalvarProduto.Iconimage_Selected = null;
            this.btnSalvarProduto.IconMarginLeft = 0;
            this.btnSalvarProduto.IconMarginRight = 0;
            this.btnSalvarProduto.IconRightVisible = true;
            this.btnSalvarProduto.IconRightZoom = 0D;
            this.btnSalvarProduto.IconVisible = true;
            this.btnSalvarProduto.IconZoom = 90D;
            this.btnSalvarProduto.IsTab = false;
            this.btnSalvarProduto.Location = new System.Drawing.Point(451, 452);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvarProduto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalvarProduto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvarProduto.selected = false;
            this.btnSalvarProduto.Size = new System.Drawing.Size(173, 48);
            this.btnSalvarProduto.TabIndex = 8;
            this.btnSalvarProduto.Text = "bunifuFlatButton1";
            this.btnSalvarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProduto.Textcolor = System.Drawing.Color.White;
            this.btnSalvarProduto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnLimparCampo
            // 
            this.btnLimparCampo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimparCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimparCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparCampo.BorderRadius = 0;
            this.btnLimparCampo.ButtonText = "bunifuFlatButton2";
            this.btnLimparCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampo.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimparCampo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimparCampo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLimparCampo.Iconimage")));
            this.btnLimparCampo.Iconimage_right = null;
            this.btnLimparCampo.Iconimage_right_Selected = null;
            this.btnLimparCampo.Iconimage_Selected = null;
            this.btnLimparCampo.IconMarginLeft = 0;
            this.btnLimparCampo.IconMarginRight = 0;
            this.btnLimparCampo.IconRightVisible = true;
            this.btnLimparCampo.IconRightZoom = 0D;
            this.btnLimparCampo.IconVisible = true;
            this.btnLimparCampo.IconZoom = 90D;
            this.btnLimparCampo.IsTab = false;
            this.btnLimparCampo.Location = new System.Drawing.Point(210, 452);
            this.btnLimparCampo.Name = "btnLimparCampo";
            this.btnLimparCampo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLimparCampo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLimparCampo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimparCampo.selected = false;
            this.btnLimparCampo.Size = new System.Drawing.Size(186, 48);
            this.btnLimparCampo.TabIndex = 9;
            this.btnLimparCampo.Text = "bunifuFlatButton2";
            this.btnLimparCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampo.Textcolor = System.Drawing.Color.White;
            this.btnLimparCampo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.HintForeColor = System.Drawing.Color.Empty;
            this.txtValor.HintText = "";
            this.txtValor.isPassword = false;
            this.txtValor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtValor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtValor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtValor.LineThickness = 3;
            this.txtValor.Location = new System.Drawing.Point(210, 360);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(186, 33);
            this.txtValor.TabIndex = 11;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label5.Location = new System.Drawing.Point(71, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // UcAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimparCampo);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcAdicionarProduto";
            this.Size = new System.Drawing.Size(706, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtModelo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantidade;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvarProduto;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimparCampo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValor;
        private System.Windows.Forms.Label label5;
    }
}

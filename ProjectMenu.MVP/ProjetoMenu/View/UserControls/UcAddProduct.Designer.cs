namespace ProjetoMenu.View.UserControls
{
    partial class UcAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAddProduct));
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
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(99, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(72, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(60, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Gray;
            this.txtMarca.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txtMarca.HintText = "";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.Gainsboro;
            this.txtMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.txtMarca.LineThickness = 4;
            this.txtMarca.Location = new System.Drawing.Point(207, 24);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(409, 49);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.Gray;
            this.txtModelo.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txtModelo.HintText = "";
            this.txtModelo.isPassword = false;
            this.txtModelo.LineFocusedColor = System.Drawing.Color.Gainsboro;
            this.txtModelo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtModelo.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.txtModelo.LineThickness = 4;
            this.txtModelo.Location = new System.Drawing.Point(207, 86);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(409, 45);
            this.txtModelo.TabIndex = 5;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.Gray;
            this.txtTipo.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txtTipo.HintText = "";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.Gainsboro;
            this.txtTipo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.txtTipo.LineThickness = 4;
            this.txtTipo.Location = new System.Drawing.Point(207, 142);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(409, 45);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            this.txtTipo.Leave += new System.EventHandler(this.txtTipo_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantidade.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txtQuantidade.HintText = "";
            this.txtQuantidade.isPassword = false;
            this.txtQuantidade.LineFocusedColor = System.Drawing.Color.Gainsboro;
            this.txtQuantidade.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantidade.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.txtQuantidade.LineThickness = 4;
            this.txtQuantidade.Location = new System.Drawing.Point(207, 199);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(173, 46);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSalvarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarProduto.BorderRadius = 0;
            this.btnSalvarProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSalvarProduto.ButtonText = "Salvar";
            this.btnSalvarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProduto.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnSalvarProduto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSalvarProduto.IconZoom = 40D;
            this.btnSalvarProduto.IsTab = false;
            this.btnSalvarProduto.Location = new System.Drawing.Point(443, 358);
            this.btnSalvarProduto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSalvarProduto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnSalvarProduto.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnSalvarProduto.selected = false;
            this.btnSalvarProduto.Size = new System.Drawing.Size(173, 50);
            this.btnSalvarProduto.TabIndex = 8;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvarProduto.Textcolor = System.Drawing.Color.DarkGray;
            this.btnSalvarProduto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnLimparCampo
            // 
            this.btnLimparCampo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnLimparCampo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparCampo.BorderRadius = 0;
            this.btnLimparCampo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLimparCampo.ButtonText = "Limpar";
            this.btnLimparCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampo.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnLimparCampo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLimparCampo.IconZoom = 40D;
            this.btnLimparCampo.IsTab = false;
            this.btnLimparCampo.Location = new System.Drawing.Point(207, 358);
            this.btnLimparCampo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLimparCampo.Name = "btnLimparCampo";
            this.btnLimparCampo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLimparCampo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnLimparCampo.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnLimparCampo.selected = false;
            this.btnLimparCampo.Size = new System.Drawing.Size(173, 50);
            this.btnLimparCampo.TabIndex = 9;
            this.btnLimparCampo.Text = "Limpar";
            this.btnLimparCampo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparCampo.Textcolor = System.Drawing.Color.DarkGray;
            this.btnLimparCampo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Gray;
            this.txtValor.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txtValor.HintText = "";
            this.txtValor.isPassword = false;
            this.txtValor.LineFocusedColor = System.Drawing.Color.Gainsboro;
            this.txtValor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtValor.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.txtValor.LineThickness = 4;
            this.txtValor.Location = new System.Drawing.Point(207, 259);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(173, 47);
            this.txtValor.TabIndex = 11;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(106, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // UcAddProduct
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
            this.Name = "UcAddProduct";
            this.Size = new System.Drawing.Size(818, 464);
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

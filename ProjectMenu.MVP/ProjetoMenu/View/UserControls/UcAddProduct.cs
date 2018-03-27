using ProjetoMenu.Model.Repositories;
using ProjetoMenu.Presenter;
using ProjetoMenu.View.Interfaces;
using System;
using System.Windows.Forms;

namespace ProjetoMenu.View.UserControls
{
    public partial class UcAddProduct : UserControl, IAddProductView
    {
        private static UcAddProduct __instance;

        public static UcAddProduct Instance
        {
            get
            {
                if (__instance == null)
                {
                    __instance = new UcAddProduct();
                }
                return __instance;
            }
        }

        public string Brand { get => txtMarca.Text; set => txtMarca.Text = value; }
        public string Model { get => txtModelo.Text; set => txtModelo.Text = value; }
        public string Description { get => txtTipo.Text; set => txtTipo.Text = value; }
        public int Amount { get => int.Parse(txtQuantidade.Text); set => txtQuantidade.Text = value.ToString(); }
        public decimal Price { get => int.Parse(txtValor.Text); set => txtValor.Text = value.ToString(); }

        public UcAddProduct()
        {
            InitializeComponent();
        }

        private AddProductPresenter _presenter;

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter = new AddProductPresenter(this, new ProductRepository());
                _presenter.AddProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }

        #region

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Gainsboro;

        }

        private void txtModelo_Enter(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Gainsboro;
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.DarkGray;
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.DarkGray;
        }

        private void txtTipo_Leave(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.DarkGray;
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.DarkGray;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.DarkGray;
        }

        #endregion
    }
}

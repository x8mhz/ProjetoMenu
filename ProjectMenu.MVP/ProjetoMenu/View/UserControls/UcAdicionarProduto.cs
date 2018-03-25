using ProjetoMenu.Presenter;
using ProjetoMenu.View.Interfaces;
using System;
using System.Windows.Forms;

namespace ProjetoMenu.View.UserControls
{
    public partial class UcAdicionarProduto : UserControl, IProdutoView
    {
        private static UcAdicionarProduto _instancia;

        public static UcAdicionarProduto Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UcAdicionarProduto();
                }
                return _instancia;
            }
        }

        public string Marca { get => txtMarca.Text; set => txtMarca.Text = value; }
        public string Modelo { get => txtModelo.Text; set => txtModelo.Text = value; }
        public string Tipo { get => txtTipo.Text; set => txtTipo.Text = value; }
        public int Quantidade { get => int.Parse(txtQuantidade.Text); set => txtQuantidade.Text = value.ToString(); }
        public decimal Valor { get => int.Parse(txtValor.Text); set => txtValor.Text = value.ToString(); }

        public UcAdicionarProduto()
        {
            InitializeComponent();
        }

        private ProdutoPresenter _presenter;

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter = new ProdutoPresenter(this);
                _presenter.Adicionar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
    }
}

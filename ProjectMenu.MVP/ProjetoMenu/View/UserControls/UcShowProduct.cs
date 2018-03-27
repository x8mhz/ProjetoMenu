using ProjetoMenu.Model.Entities;
using ProjetoMenu.Model.Repositories;
using ProjetoMenu.Presenter;
using ProjetoMenu.View.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoMenu.View.UserControls
{
    public partial class UcShowProduct : UserControl, IShowProductView
    {
        private static UcShowProduct _instance;

        public static UcShowProduct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcShowProduct();
                }
                return _instance;
            }
        }

        public UcShowProduct()
        {
            InitializeComponent();
            gvShowProduct.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 24);
            gvShowProduct.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 14f, System.Drawing.GraphicsUnit.Pixel);
        }

        private ShowProductPresenter presenter;

        public void LoadProduct(IEnumerable<Product> products)
        {
            gvShowProduct.DataSource = products;
        }

        private void UcShowProduct_Load(object sender, System.EventArgs e)
        {
            presenter = new ShowProductPresenter(this, new ProductRepository());
        }

    }
}

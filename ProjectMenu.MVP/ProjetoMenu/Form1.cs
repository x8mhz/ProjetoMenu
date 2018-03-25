using ProjetoMenu.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (!pnPrincipal.Controls.Contains(UcAdicionarProduto.Instancia))
            {
                pnPrincipal.Controls.Add(UcAdicionarProduto.Instancia);
                UcAdicionarProduto.Instancia.Dock = DockStyle.Fill;
                UcAdicionarProduto.Instancia.BringToFront();
            }
            else
            {
                UcAdicionarProduto.Instancia.BringToFront();
            }
        }
    }
}

using ProjetoMenu.View.UserControls;
using System;
using System.Windows.Forms;

namespace ProjetoMenu
{
    public partial class Form1 : Form
    {
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!pnPrincipal.Controls.Contains(UcAddProduct.Instance))
            {
                pnPrincipal.Controls.Add(UcAddProduct.Instance);
                UcAddProduct.Instance.Dock = DockStyle.Fill;
                UcAddProduct.Instance.BringToFront();
            }
            else
            {
                UcAddProduct.Instance.BringToFront();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            if (!pnPrincipal.Controls.Contains(UcShowProduct.Instance))
            {
                pnPrincipal.Controls.Add(UcShowProduct.Instance);
                UcShowProduct.Instance.Dock = DockStyle.Fill;
                UcShowProduct.Instance.BringToFront();
            }
            else
            {
                UcShowProduct.Instance.BringToFront();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.ForeColor = System.Drawing.Color.DarkGray;
        }
    }
}

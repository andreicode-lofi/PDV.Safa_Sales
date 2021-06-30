using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdvSafeSales
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        //btn do Menu principal Produto
        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            frm_CadastroProduto frm = new frm_CadastroProduto();
            frm.Show();
        }

        //btn do Menu principal categoria
        private void btnCadastraCategoria_Click(object sender, EventArgs e)
        {
            frm_CadastroCategoria frm = new frm_CadastroCategoria();
            frm.Show();
        }


        //btn do Menu principal consultar produto
        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultarProduto frm = new frmConsultarProduto();
            frm.Show();
        }

        //btn do Menu principal vendas
        private void button2_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }

        //btn menuPrincipal relatorio produto
        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            frm_RelatorioProduto frm = new frm_RelatorioProduto();
            frm.Show();

        }

        //btn menuPrincipal cadastra client
        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            frm_CadastraCliente frm = new frm_CadastraCliente();
            frm.Show();
        }

        //btn menuPrincipal Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCadastraUser_Click(object sender, EventArgs e)
        {
            frm_cadastroUser frm = new frm_cadastroUser();
            frm.Show();
        }





        //btn MenuStrip produto
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroProduto frm = new frm_CadastroProduto();
            frm.Show();
        }

        //btn MenuStrip categoria
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroCategoria frm = new frm_CadastroCategoria();
        }

        
        // btn menoStrip Consulta Produtos
        private void produtosCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProduto frm = new frmConsultarProduto();
            frm.Show();
        }

        // btn menoStrip venda
        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }

     

        //btn menoStrip relatorio
        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //frmRelatorio_Produto frm = new frmRelatorio_Produto();
           // frm.Show();
        }

        //btn menoStrip CadastraCliente
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastraCliente frm = new frm_CadastraCliente();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales system 1.0 \nWritten by: Andrey Souza", "Sales system", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

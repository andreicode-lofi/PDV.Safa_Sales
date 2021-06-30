using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.Dal;

namespace PdvSafeSales
{
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
        }

        private void frmConsultarProduto_Load(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto;
            categoriaBindingSource.DataSource = DataContexFactory.DataContext.Categoria;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar((int)cb_Categoria.SelectedValue);
            
        }


        //Metodo para buscar produtos na categoria
        public void Pesquisar(int codigoCategoria)
        {
            produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto.Where(x => x.id_Categoria == codigoCategoria);
        }

       
    }
}

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
    public partial class frm_CadastroProduto : Form
    {       
        public frm_CadastroProduto()
        {
            InitializeComponent();
        }

        private void frm_CadastroProduto_Load(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto;
            categoriaBindingSource.DataSource = DataContexFactory.DataContext.Categoria;
        }

        //btn novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            produtoBindingSource.AddNew();
        }


        //btn Cadastro
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            if (ValidarCampo())
            {
                produtoBindingSource.EndEdit();
                DataContexFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro");
            }
        }

        //validando compo vazio 
        private bool ValidarCampo()
        {
            if(txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor preencha os campos obrigatórios", "Error");
                txtDescricao.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //btn excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir esse produto ?","Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produtoBindingSource.RemoveCurrent();
                DataContexFactory.DataContext.SubmitChanges();
                MessageBox.Show("Produto Excluido com sucesso", "Excluir Produto");
            }
        }

        //btn cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
        }

        //Mostra a categoria na dataGrid
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((Categoria)e.Value).descricao_Categoria;
            }
        }
    }
}

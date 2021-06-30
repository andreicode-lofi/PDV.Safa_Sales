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
    public partial class frm_CadastroCategoria : Form
    {
        public frm_CadastroCategoria()
        {
            InitializeComponent();
        }

        private void frm_CadastroCategoria_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = DataContexFactory.DataContext.Categoria;
        }


        //btn novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.AddNew();
        }

        //btn cadastra
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                categoriaBindingSource.EndEdit();
                DataContexFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria cadastrada com sucesso", "Cadastro");
            }
        }

        //Validação para não deixa cadastra categoria vazia
        private bool VerificaCampo()
        {
            if (txtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome da categoria é obrigatorio para cadastra", "Erro");
                txtCategoria.Focus();
                return false;
            }
            return true;
        }

        //btn Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
           

            if(MessageBox.Show("Tem certeza que você deseja excluir essa categoria ?","Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CategoriaPossuiProduto(categoriaAtual))//validação categoria atual, categoria possuiProduto
                {
                    MessageBox.Show("Não é possivel excluir essa categoria, tem produtos nela", "Error");
                }
                else
                {
                    categoriaBindingSource.RemoveCurrent();
                    DataContexFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Excluirdo com sucesso", "Excluir");
                }
            }
        }

        //btn cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.CancelEdit();
        }

        //(Validação Excluir) Metodo para pegar a categoria atual
        public Categoria categoriaAtual
        {
            get
            {
                return (Categoria)categoriaBindingSource.Current;
            }
        }

        //(Validação Excluir)  metodo para verificar se tem produto na categoria
        private bool CategoriaPossuiProduto(Categoria categoria)
        {
            var produto = DataContexFactory.DataContext.Produto.Where(x => x.id_Categoria == categoria.id_Categoria);
            if (produto.Count() > 0)
                return true;
            else
                return false;
        }


       
    }
}

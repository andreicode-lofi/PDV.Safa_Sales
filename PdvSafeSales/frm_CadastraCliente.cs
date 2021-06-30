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
    public partial class frm_CadastraCliente : Form
    {
        public frm_CadastraCliente()
        {
            InitializeComponent();
        }

        private void frm_CadastraCliente_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = DataContexFactory.DataContext.Cliente;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                clienteBindingSource.RemoveCurrent();
                DataContexFactory.DataContext.SubmitChanges();
                MessageBox.Show("Excluido com sucesso");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            if( validar())
            {
                clienteBindingSource.EndEdit();
                DataContexFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Cadastrado com sucesso");
            }
        }

        private bool validar()
        {
            if(txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor preencha os campos obrigatórios", "Error");
                txtNome.Focus();
                return false;
            }
            return true;
        }
    }
}

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
    public partial class frm_cadastroUser : Form
    {
        public frm_cadastroUser()
        {
            InitializeComponent();
        }

        private void frm_cadastroUser_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = DataContexFactory.DataContext.Usuario;
        }

        //btn novo
        private void btnNova_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.CancelEdit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                usuarioBindingSource.RemoveCurrent();
                DataContexFactory.DataContext.SubmitChanges();
                MessageBox.Show("Excluido com sucesso");

            }
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                usuarioBindingSource.EndEdit();
                DataContexFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Cadastrado com sucesso");
            }
        }

        private bool validar()
        {
            if(txtUser.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor preencha os campos obrigatórios", "Error");
                txtUser.Focus();
                return false;
            }
            return true;
        }
    }
}

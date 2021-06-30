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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }


        public bool logado = false;

        // metodo verificando login senha
        private void EfetuarLoging()
        {
            var user = DataContexFactory.DataContext.Usuario.Count(x => x.usuario == txtUsuario.Text && x.senha == txtSenha.Text);
           if(user > 0)
           {
                logado = true;
                Dispose();
           }
           else
           {
               MessageBox.Show("Usuário ou senha incorreto");
                
           }
        } 


        //btn login
        private void button2_Click(object sender, EventArgs e)
        {
            EfetuarLoging();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

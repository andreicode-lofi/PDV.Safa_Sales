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
    public partial class frm_RelatorioProduto : Form
    {
        public frm_RelatorioProduto()
        {
            InitializeComponent();
        }

        private void frm_RelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_Pvd_SafeSalesDataSet1.tb_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ProdutoTableAdapter.Fill(this.db_Pvd_SafeSalesDataSet1.tb_Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}

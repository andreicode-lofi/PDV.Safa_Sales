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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = DataContexFactory.DataContext.Cliente;
            vendaBindingSource.DataSource = DataContexFactory.DataContext.Venda;
            itens_vendaBindingSource.DataSource = DataContexFactory.DataContext.Itens_venda;
            produtoBindingSource.DataSource = DataContexFactory.DataContext.Produto;
            conta_receberBindingSource.DataSource = DataContexFactory.DataContext.Conta_receber;
            statusBindingSource.DataSource = DataContexFactory.DataContext.Status;
            vendaBindingSource.AddNew();
        }

        //Metodo para chamar a tabela venda
        public Venda VendaCorrente
        {
            get
            {
                return (Venda)vendaBindingSource.Current;
            }
        }

        //Metodo para chamar a tabela itens_Vendas
        public Itens_venda itensVendaCorrente
        {
            get
            {
                return (Itens_venda)itens_vendaBindingSource.Current;
            }
        }

        //Metodo para chamar tabelca conta recente
        public  Conta_receber contaReceberCorrente
        {
            get
            {
                return (Conta_receber)conta_receberBindingSource.Current;
            }
        }



        //btn nova venda
        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            vendaBindingSource.EndEdit();
            DataContexFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btnNovaVenda.Enabled = false;
            itens_vendaBindingSource.DataSource = DataContexFactory.DataContext.Itens_venda.Where(x => x.id_produto == VendaCorrente.id_venda);
            NovoItem();
            cb_Cliente.Enabled = false;
        }

        //Metodo verificando novo iten
        private void NovoItem()
        {
            itens_vendaBindingSource.AddNew();
            itensVendaCorrente.id_Venda = VendaCorrente.id_venda;
            itensVendaCorrente.quantidade = 1;
            
        }

        private void btnNovoitem_Click(object sender, EventArgs e)
        {
            itens_vendaBindingSource.EndEdit();
            dg_Venda.Refresh();
            ValorTotal();
            DataContexFactory.DataContext.SubmitChanges();
            NovoItem();
            
        }

        //metodo para mostra produto na data grid
        private void itens_vendaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).descricao_Produto;
        }

        //Metodo mostra valor na data grid
        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Produto.SelectedItem != null)
            {
                var rsp = (Produto)cb_Produto.SelectedItem;
                itensVendaCorrente.id_produto = (int)rsp.id_Produto;
                itensVendaCorrente.valor = (decimal)rsp.valor;
            }
        }


        //Metodo fazendo calculo do valor total
        private void ValorTotal()
        {
            decimal valorTotal = 0;

            foreach (DataGridViewRow dg in dg_Venda.Rows)
            {
                decimal quatidade = Convert.ToDecimal( dg.Cells[2].Value);
                decimal valor = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subTotal = quatidade * valor;
                dg.Cells[4].Value = subTotal;

                valorTotal = valorTotal + subTotal;
            }

            VendaCorrente.valor = valorTotal;

            
        }

        //finalizando pedido
        private void btnFinalizaPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido ? ", "Finalizar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                itens_vendaBindingSource.CancelEdit();
                DataContexFactory.DataContext.SubmitChanges();
                VendaCorrente.desconto = 0;
                btnNovoitem.Enabled = false;
                cb_Produto.Enabled = false;
                txtQuantidade.Enabled = false;
                btnFinalizarVenda.Enabled = true;
                btnImprimir.Enabled = false;
                txtDesconto.ReadOnly = false;
                txtDesconto.Focus();
                btnFinalizaPedido.Enabled = false;
                txtValorPago.ReadOnly = true;
                txtCodigoVenda.Enabled = false;

            }
           
        }

        //finalizando a venda
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            VendaCorrente.desconto = Convert.ToDecimal(txtDesconto.Text);
            VendaCorrente.valor_pago = (decimal)(VendaCorrente.valor - VendaCorrente.desconto);
            vendaBindingSource.EndEdit();
            DataContexFactory.DataContext.SubmitChanges();
            txtDesconto.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            //btnImprimir.Enabled = true;
            cbFormaPagamento.Enabled = true;
            

            conta_receberBindingSource.AddNew();
            contaReceberCorrente.id_venda = VendaCorrente.id_venda;
            contaReceberCorrente.data_compra = DateTime.Now;
            contaReceberCorrente.data_vencimento = DateTime.Now;
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFormaPagamento.SelectedItem != null)
            {
                var status = (Status)cbFormaPagamento.SelectedItem;
                if(status.id_status == 1)
                {
                    contaReceberCorrente.id_status = (int)status.id_status;
                    contaReceberCorrente.data_pagamento = DateTime.Now;
                    btnFinalizar.Enabled = true;
                    data_vencimento.Enabled = false;
                }
                else if(status.id_status == 2)
                {
                    contaReceberCorrente.id_status = (int)status.id_status;
                    contaReceberCorrente.data_vencimento = DateTime.Now;
                    data_vencimento.Enabled = true;
                    btnFinalizar.Enabled = true;

                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            conta_receberBindingSource.EndEdit();
            data_vencimento.Enabled = false;
            btnFinalizar.Enabled = false;
            cbFormaPagamento.Enabled = false;
            btnImprimir.Enabled = true;
            DataContexFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com sucesso");
        }
    }
}

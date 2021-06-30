
namespace PdvSafeSales
{
    partial class frm_venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label id_produtoLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label id_statusLabel;
            System.Windows.Forms.Label data_vencimentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.data_vencimento = new System.Windows.Forms.DateTimePicker();
            this.conta_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.dg_Venda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itens_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFinalizaPedido = new System.Windows.Forms.Button();
            this.btnNovoitem = new System.Windows.Forms.Button();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.cb_Produto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            id_vendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            id_produtoLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            id_statusLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.ForeColor = System.Drawing.Color.Black;
            id_vendaLabel.Location = new System.Drawing.Point(20, 37);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(116, 18);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "Código venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.ForeColor = System.Drawing.Color.Black;
            quantidadeLabel.Location = new System.Drawing.Point(16, 117);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(98, 18);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.ForeColor = System.Drawing.Color.Black;
            valorLabel.Location = new System.Drawing.Point(20, 152);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(50, 18);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "valor:";
            // 
            // id_produtoLabel1
            // 
            id_produtoLabel1.AutoSize = true;
            id_produtoLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_produtoLabel1.ForeColor = System.Drawing.Color.Black;
            id_produtoLabel1.Location = new System.Drawing.Point(20, 78);
            id_produtoLabel1.Name = "id_produtoLabel1";
            id_produtoLabel1.Size = new System.Drawing.Size(70, 20);
            id_produtoLabel1.TabIndex = 8;
            id_produtoLabel1.Text = "Produto:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descontoLabel.ForeColor = System.Drawing.Color.Black;
            descontoLabel.Location = new System.Drawing.Point(16, 414);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(86, 18);
            descontoLabel.TabIndex = 22;
            descontoLabel.Text = "Desconto:";
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_pagoLabel.ForeColor = System.Drawing.Color.Black;
            valor_pagoLabel.Location = new System.Drawing.Point(16, 449);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(95, 18);
            valor_pagoLabel.TabIndex = 23;
            valor_pagoLabel.Text = "Valor Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(16, 385);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 18);
            label2.TabIndex = 12;
            label2.Text = "valor:";
            // 
            // id_statusLabel
            // 
            id_statusLabel.AutoSize = true;
            id_statusLabel.ForeColor = System.Drawing.Color.Black;
            id_statusLabel.Location = new System.Drawing.Point(339, 385);
            id_statusLabel.Name = "id_statusLabel";
            id_statusLabel.Size = new System.Drawing.Size(161, 18);
            id_statusLabel.TabIndex = 29;
            id_statusLabel.Text = "Forama Pagamento:";
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.ForeColor = System.Drawing.Color.Black;
            data_vencimentoLabel.Location = new System.Drawing.Point(339, 414);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(141, 18);
            data_vencimentoLabel.TabIndex = 30;
            data_vencimentoLabel.Text = "Data Vencimento:";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "id_pessoa", true));
            this.cb_Cliente.DataSource = this.clienteBindingSource;
            this.cb_Cliente.DisplayMember = "descricao_pessoa";
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(88, 69);
            this.cb_Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(348, 21);
            this.cb_Cliente.TabIndex = 2;
            this.cb_Cliente.ValueMember = "id_pessoa";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.Dal.Venda);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(sistema.Dal.Cliente);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 18);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente: ";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(456, 69);
            this.btnNovaVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(75, 22);
            this.btnNovaVenda.TabIndex = 4;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(data_vencimentoLabel);
            this.groupBox1.Controls.Add(this.data_vencimento);
            this.groupBox1.Controls.Add(id_statusLabel);
            this.groupBox1.Controls.Add(this.cbFormaPagamento);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnFinalizarVenda);
            this.groupBox1.Controls.Add(this.dg_Venda);
            this.groupBox1.Controls.Add(this.btnFinalizaPedido);
            this.groupBox1.Controls.Add(this.btnNovoitem);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(id_produtoLabel1);
            this.groupBox1.Controls.Add(this.txtValorPago);
            this.groupBox1.Controls.Add(this.cb_Produto);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(valor_pagoLabel);
            this.groupBox1.Controls.Add(this.txtValorProduto);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(id_vendaLabel);
            this.groupBox1.Controls.Add(this.txtCodigoVenda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(650, 491);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova venda";
            this.groupBox1.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(506, 448);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(124, 23);
            this.btnFinalizar.TabIndex = 32;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // data_vencimento
            // 
            this.data_vencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.conta_receberBindingSource, "data_vencimento", true));
            this.data_vencimento.Enabled = false;
            this.data_vencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_vencimento.Location = new System.Drawing.Point(506, 415);
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.Size = new System.Drawing.Size(124, 20);
            this.data_vencimento.TabIndex = 31;
            // 
            // conta_receberBindingSource
            // 
            this.conta_receberBindingSource.DataSource = typeof(sistema.Dal.Conta_receber);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(sistema.Dal.Status);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(234, 448);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 23);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PdvSafeSales.Properties.Resources.оплата_png_2;
            this.pictureBox1.Location = new System.Drawing.Point(417, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Enabled = false;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(234, 413);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(99, 23);
            this.btnFinalizarVenda.TabIndex = 28;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // dg_Venda
            // 
            this.dg_Venda.AllowUserToAddRows = false;
            this.dg_Venda.AllowUserToDeleteRows = false;
            this.dg_Venda.AutoGenerateColumns = false;
            this.dg_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.dg_Venda.DataSource = this.itens_vendaBindingSource;
            this.dg_Venda.Location = new System.Drawing.Point(6, 225);
            this.dg_Venda.Name = "dg_Venda";
            this.dg_Venda.ReadOnly = true;
            this.dg_Venda.Size = new System.Drawing.Size(624, 142);
            this.dg_Venda.TabIndex = 10;
            this.dg_Venda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.itens_vendaDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_produto";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn8.HeaderText = "Código produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn13.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn11.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "valor_total";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn12.HeaderText = "Valor total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // itens_vendaBindingSource
            // 
            this.itens_vendaBindingSource.DataSource = typeof(sistema.Dal.Itens_venda);
            // 
            // btnFinalizaPedido
            // 
            this.btnFinalizaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizaPedido.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizaPedido.Location = new System.Drawing.Point(234, 381);
            this.btnFinalizaPedido.Name = "btnFinalizaPedido";
            this.btnFinalizaPedido.Size = new System.Drawing.Size(99, 23);
            this.btnFinalizaPedido.TabIndex = 27;
            this.btnFinalizaPedido.Text = "Fenalizar Pedido";
            this.btnFinalizaPedido.UseVisualStyleBackColor = true;
            this.btnFinalizaPedido.Click += new System.EventHandler(this.btnFinalizaPedido_Click);
            // 
            // btnNovoitem
            // 
            this.btnNovoitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoitem.ForeColor = System.Drawing.Color.Black;
            this.btnNovoitem.Location = new System.Drawing.Point(280, 151);
            this.btnNovoitem.Name = "btnNovoitem";
            this.btnNovoitem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoitem.TabIndex = 10;
            this.btnNovoitem.Text = "Novos itens";
            this.btnNovoitem.UseVisualStyleBackColor = true;
            this.btnNovoitem.Click += new System.EventHandler(this.btnNovoitem_Click);
            // 
            // txtValorPago
            // 
            this.txtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor_pago", true));
            this.txtValorPago.ForeColor = System.Drawing.Color.Red;
            this.txtValorPago.Location = new System.Drawing.Point(114, 447);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.ReadOnly = true;
            this.txtValorPago.Size = new System.Drawing.Size(100, 24);
            this.txtValorPago.TabIndex = 25;
            // 
            // cb_Produto
            // 
            this.cb_Produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itens_vendaBindingSource, "id_produto", true));
            this.cb_Produto.DataSource = this.produtoBindingSource;
            this.cb_Produto.DisplayMember = "descricao_Produto";
            this.cb_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Produto.FormattingEnabled = true;
            this.cb_Produto.Location = new System.Drawing.Point(158, 76);
            this.cb_Produto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Produto.Name = "cb_Produto";
            this.cb_Produto.Size = new System.Drawing.Size(253, 23);
            this.cb_Produto.TabIndex = 9;
            this.cb_Produto.ValueMember = "id_Produto";
            this.cb_Produto.SelectedIndexChanged += new System.EventHandler(this.cb_Produto_SelectedIndexChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(sistema.Dal.Produto);
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor", true));
            this.txtValor.Location = new System.Drawing.Point(114, 383);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 24);
            this.txtValor.TabIndex = 24;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor", true));
            this.txtValorProduto.Location = new System.Drawing.Point(158, 149);
            this.txtValorProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.ReadOnly = true;
            this.txtValorProduto.Size = new System.Drawing.Size(100, 24);
            this.txtValorProduto.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itens_vendaBindingSource, "quantidade", true));
            this.txtQuantidade.Location = new System.Drawing.Point(158, 111);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 24);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "id_venda", true));
            this.txtCodigoVenda.Location = new System.Drawing.Point(158, 32);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.ReadOnly = true;
            this.txtCodigoVenda.Size = new System.Drawing.Size(100, 24);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registra vendas";
            // 
            // txtDesconto
            // 
            this.txtDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "desconto", true));
            this.txtDesconto.Location = new System.Drawing.Point(114, 413);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 24);
            this.txtDesconto.TabIndex = 33;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.conta_receberBindingSource, "id_status", true));
            this.cbFormaPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "status", true));
            this.cbFormaPagamento.DataSource = this.statusBindingSource;
            this.cbFormaPagamento.DisplayMember = "status";
            this.cbFormaPagamento.Enabled = false;
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(506, 379);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(124, 26);
            this.cbFormaPagamento.TabIndex = 30;
            this.cbFormaPagamento.ValueMember = "id_status";
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cb_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.BindingSource itens_vendaBindingSource;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.ComboBox cb_Produto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnNovoitem;
        private System.Windows.Forms.DataGridView dg_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Button btnFinalizaPedido;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource conta_receberBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DateTimePicker data_vencimento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
    }
}
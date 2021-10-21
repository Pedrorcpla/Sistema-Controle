
namespace ProjetoBancoDados
{
    partial class frmProduto
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
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.Windows.Forms.Label nm_categoriaLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cadastroDataSet = new ProjetoBancoDados.CadastroDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new ProjetoBancoDados.CadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDados.CadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            nm_categoriaLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_produtoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            cd_produtoLabel.Location = new System.Drawing.Point(233, 152);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(63, 20);
            cd_produtoLabel.TabIndex = 60;
            cd_produtoLabel.Text = "Código:";
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_produtoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nm_produtoLabel.Location = new System.Drawing.Point(241, 184);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(55, 20);
            nm_produtoLabel.TabIndex = 62;
            nm_produtoLabel.Text = "Nome:";
            // 
            // nm_categoriaLabel
            // 
            nm_categoriaLabel.AutoSize = true;
            nm_categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_categoriaLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nm_categoriaLabel.Location = new System.Drawing.Point(214, 216);
            nm_categoriaLabel.Name = "nm_categoriaLabel";
            nm_categoriaLabel.Size = new System.Drawing.Size(82, 20);
            nm_categoriaLabel.TabIndex = 64;
            nm_categoriaLabel.Text = "Categoria:";
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            qt_estoqueLabel.Location = new System.Drawing.Point(114, 248);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(182, 20);
            qt_estoqueLabel.TabIndex = 66;
            qt_estoqueLabel.Text = "Quantidade no Estoque:";
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_custoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            vl_custoLabel.Location = new System.Drawing.Point(178, 280);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(118, 20);
            vl_custoLabel.TabIndex = 68;
            vl_custoLabel.Text = "Valor de Custo:";
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_vendaLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            vl_vendaLabel.Location = new System.Drawing.Point(173, 312);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(123, 20);
            vl_vendaLabel.TabIndex = 70;
            vl_vendaLabel.Text = "Valor de Venda:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterar.Location = new System.Drawing.Point(491, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 53;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Location = new System.Drawing.Point(633, 58);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 59;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.Location = new System.Drawing.Point(633, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnProximo.Location = new System.Drawing.Point(207, 12);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(100, 30);
            this.btnProximo.TabIndex = 51;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimir.Location = new System.Drawing.Point(491, 58);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 58;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisar.Location = new System.Drawing.Point(349, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 57;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(207, 58);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovo.Location = new System.Drawing.Point(349, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 52;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.Location = new System.Drawing.Point(65, 58);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnterior.Location = new System.Drawing.Point(65, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 30);
            this.btnAnterior.TabIndex = 50;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = this.tbProdutoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDados.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "cd_produto", true));
            this.cd_produtoTextBox.Enabled = false;
            this.cd_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_produtoTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cd_produtoTextBox.Location = new System.Drawing.Point(302, 149);
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_produtoTextBox.TabIndex = 61;
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "nm_produto", true));
            this.nm_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_produtoTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nm_produtoTextBox.Location = new System.Drawing.Point(302, 181);
            this.nm_produtoTextBox.MaxLength = 50;
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(288, 26);
            this.nm_produtoTextBox.TabIndex = 63;
            // 
            // nm_categoriaTextBox
            // 
            this.nm_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "nm_categoria", true));
            this.nm_categoriaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_categoriaTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nm_categoriaTextBox.Location = new System.Drawing.Point(302, 213);
            this.nm_categoriaTextBox.MaxLength = 30;
            this.nm_categoriaTextBox.Name = "nm_categoriaTextBox";
            this.nm_categoriaTextBox.Size = new System.Drawing.Size(288, 26);
            this.nm_categoriaTextBox.TabIndex = 65;
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "qt_estoque", true));
            this.qt_estoqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_estoqueTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(302, 245);
            this.qt_estoqueTextBox.MaxLength = 4;
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(100, 26);
            this.qt_estoqueTextBox.TabIndex = 67;
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_custo", true));
            this.vl_custoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_custoTextBox.Location = new System.Drawing.Point(302, 277);
            this.vl_custoTextBox.MaxLength = 8;
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(100, 26);
            this.vl_custoTextBox.TabIndex = 72;
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_venda", true));
            this.vl_vendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(302, 309);
            this.vl_vendaTextBox.MaxLength = 8;
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(100, 26);
            this.vl_vendaTextBox.TabIndex = 73;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vl_vendaTextBox);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(nm_categoriaLabel);
            this.Controls.Add(this.nm_categoriaTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAnterior);
            this.Name = "frmProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAnterior;
        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private CadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox nm_categoriaTextBox;
        private System.Windows.Forms.TextBox qt_estoqueTextBox;
        private System.Windows.Forms.TextBox vl_custoTextBox;
        private System.Windows.Forms.TextBox vl_vendaTextBox;
    }
}
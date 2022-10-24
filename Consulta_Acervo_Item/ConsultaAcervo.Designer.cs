namespace Consulta_Acervo_Item
{
    partial class ConsultaAcervo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnItem = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSecao = new System.Windows.Forms.Button();
            this.btnColecao = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.labelAutor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTipoItem = new System.Windows.Forms.ComboBox();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.txtColecao = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.labelSecao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnItem.Location = new System.Drawing.Point(610, 7);
            this.btnItem.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnItem.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(19, 20);
            this.btnItem.TabIndex = 2;
            this.btnItem.Text = "🔎";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(775, 138);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSecao
            // 
            this.btnSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSecao.Location = new System.Drawing.Point(1089, 59);
            this.btnSecao.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnSecao.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnSecao.Name = "btnSecao";
            this.btnSecao.Size = new System.Drawing.Size(19, 20);
            this.btnSecao.TabIndex = 13;
            this.btnSecao.Text = "🔎";
            this.btnSecao.UseVisualStyleBackColor = true;
            this.btnSecao.Click += new System.EventHandler(this.btnSecao_Click);
            // 
            // btnColecao
            // 
            this.btnColecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnColecao.Location = new System.Drawing.Point(1144, 33);
            this.btnColecao.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.Name = "btnColecao";
            this.btnColecao.Size = new System.Drawing.Size(19, 20);
            this.btnColecao.TabIndex = 11;
            this.btnColecao.Text = "🔎";
            this.btnColecao.UseVisualStyleBackColor = true;
            this.btnColecao.Click += new System.EventHandler(this.btnColecao_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAutor.Location = new System.Drawing.Point(1089, 7);
            this.btnAutor.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnAutor.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(19, 20);
            this.btnAutor.TabIndex = 9;
            this.btnAutor.Text = "🔎";
            this.btnAutor.UseVisualStyleBackColor = true;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAutor.Location = new System.Drawing.Point(1117, 9);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(0, 17);
            this.labelAutor.TabIndex = 153;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(826, 233);
            this.dataGridView1.TabIndex = 151;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(455, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 150;
            this.label2.Text = "Item:";
            // 
            // txtItem
            // 
            this.txtItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtItem.Location = new System.Drawing.Point(557, 8);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(47, 20);
            this.txtItem.TabIndex = 1;
            this.txtItem.Leave += new System.EventHandler(this.txtItem_Leave);
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Reservado ",
            "Emprestado ",
            "Disponivel "});
            this.comboStatus.Location = new System.Drawing.Point(1038, 86);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(936, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 145;
            this.label9.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(936, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 144;
            this.label7.Text = "Seção:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(936, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 143;
            this.label5.Text = "Coleção";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(936, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 142;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(455, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 141;
            this.label3.Text = "Local:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(455, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 140;
            this.label1.Text = "Tipo do Item:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(455, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 139;
            this.label6.Text = "Nome do Item:";
            // 
            // comboTipoItem
            // 
            this.comboTipoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboTipoItem.FormattingEnabled = true;
            this.comboTipoItem.Location = new System.Drawing.Point(557, 59);
            this.comboTipoItem.Name = "comboTipoItem";
            this.comboTipoItem.Size = new System.Drawing.Size(100, 21);
            this.comboTipoItem.TabIndex = 5;
            // 
            // txtSecao
            // 
            this.txtSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSecao.Location = new System.Drawing.Point(1038, 60);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.Size = new System.Drawing.Size(45, 20);
            this.txtSecao.TabIndex = 12;
            this.txtSecao.Leave += new System.EventHandler(this.txtSecao_Leave);
            // 
            // txtColecao
            // 
            this.txtColecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtColecao.Location = new System.Drawing.Point(1038, 34);
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.Size = new System.Drawing.Size(100, 20);
            this.txtColecao.TabIndex = 10;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAutor.Location = new System.Drawing.Point(1038, 8);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(45, 20);
            this.txtAutor.TabIndex = 8;
            this.txtAutor.Leave += new System.EventHandler(this.txtAutor_Leave);
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLocal.Location = new System.Drawing.Point(557, 86);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(45, 20);
            this.txtLocal.TabIndex = 7;
            this.txtLocal.Leave += new System.EventHandler(this.txtLocal_Leave);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNomeItem.Location = new System.Drawing.Point(557, 34);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(100, 20);
            this.txtNomeItem.TabIndex = 3;
            this.txtNomeItem.Leave += new System.EventHandler(this.txtNomeItem_Leave);
            // 
            // labelSecao
            // 
            this.labelSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelSecao.AutoSize = true;
            this.labelSecao.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSecao.Location = new System.Drawing.Point(1115, 61);
            this.labelSecao.Name = "labelSecao";
            this.labelSecao.Size = new System.Drawing.Size(0, 17);
            this.labelSecao.TabIndex = 155;
            // 
            // ConsultaAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 408);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSecao);
            this.Controls.Add(this.btnColecao);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.labelSecao);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipoItem);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.txtColecao);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNomeItem);
            this.Name = "ConsultaAcervo";
            this.Text = "Consulta do Acervo";
            this.Load += new System.EventHandler(this.ConsultaAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSecao;
        private System.Windows.Forms.Button btnColecao;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTipoItem;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.TextBox txtColecao;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label labelSecao;
    }
}


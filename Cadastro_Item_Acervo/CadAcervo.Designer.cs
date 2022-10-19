namespace Cadastro_Item_Acervo
{
    partial class CadAcervo
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
            this.saveAcervo = new System.Windows.Forms.Button();
            this.deleteAcervo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.codItem = new System.Windows.Forms.TextBox();
            this.codLocal = new System.Windows.Forms.TextBox();
            this.nomeAcervo = new System.Windows.Forms.TextBox();
            this.nomeColecao = new System.Windows.Forms.TextBox();
            this.numeroExemplar = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.anoEdicao = new System.Windows.Forms.TextBox();
            this.idioma = new System.Windows.Forms.TextBox();
            this.secao = new System.Windows.Forms.TextBox();
            this.localizacao = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.codAutor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.codEditora = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.btnPesquisaEditora = new System.Windows.Forms.Label();
            this.btnPesquisaLocal = new System.Windows.Forms.Button();
            this.btnPesquisaAutor = new System.Windows.Forms.Button();
            this.labelCodLocal = new System.Windows.Forms.Label();
            this.btnPesquisaEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveAcervo
            // 
            this.saveAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveAcervo.Location = new System.Drawing.Point(696, 129);
            this.saveAcervo.MaximumSize = new System.Drawing.Size(75, 23);
            this.saveAcervo.Name = "saveAcervo";
            this.saveAcervo.Size = new System.Drawing.Size(75, 23);
            this.saveAcervo.TabIndex = 17;
            this.saveAcervo.Text = "Salvar";
            this.saveAcervo.UseVisualStyleBackColor = true;
            this.saveAcervo.Click += new System.EventHandler(this.saveAcervo_Click);
            // 
            // deleteAcervo
            // 
            this.deleteAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteAcervo.Location = new System.Drawing.Point(777, 129);
            this.deleteAcervo.MaximumSize = new System.Drawing.Size(75, 23);
            this.deleteAcervo.Name = "deleteAcervo";
            this.deleteAcervo.Size = new System.Drawing.Size(75, 23);
            this.deleteAcervo.TabIndex = 18;
            this.deleteAcervo.Text = "Excluir";
            this.deleteAcervo.UseVisualStyleBackColor = true;
            this.deleteAcervo.Click += new System.EventHandler(this.deleteAcervo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1537, 239);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código do Acervo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Acervo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código do Local";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(387, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome da Coleção";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(387, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo do Item";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(813, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Número do Exemplar";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(813, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Volume";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(813, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ano da Edição";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1148, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Código da prateleira";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(1148, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Seção";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1148, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Idioma";
            // 
            // codItem
            // 
            this.codItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.codItem.Enabled = false;
            this.codItem.Location = new System.Drawing.Point(126, 13);
            this.codItem.Name = "codItem";
            this.codItem.Size = new System.Drawing.Size(45, 20);
            this.codItem.TabIndex = 1;
            // 
            // codLocal
            // 
            this.codLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.codLocal.Location = new System.Drawing.Point(126, 64);
            this.codLocal.Name = "codLocal";
            this.codLocal.Size = new System.Drawing.Size(45, 20);
            this.codLocal.TabIndex = 3;
            this.codLocal.TextChanged += new System.EventHandler(this.codLocal_TextChanged);
            this.codLocal.Leave += new System.EventHandler(this.codLocal_Leave);
            // 
            // nomeAcervo
            // 
            this.nomeAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nomeAcervo.Location = new System.Drawing.Point(126, 39);
            this.nomeAcervo.Name = "nomeAcervo";
            this.nomeAcervo.Size = new System.Drawing.Size(188, 20);
            this.nomeAcervo.TabIndex = 2;
            this.nomeAcervo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeAcervo_KeyPress);
            // 
            // nomeColecao
            // 
            this.nomeColecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nomeColecao.Location = new System.Drawing.Point(510, 38);
            this.nomeColecao.Name = "nomeColecao";
            this.nomeColecao.Size = new System.Drawing.Size(188, 20);
            this.nomeColecao.TabIndex = 9;
            this.nomeColecao.TextChanged += new System.EventHandler(this.nomeColecao_TextChanged);
            this.nomeColecao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeColecao_KeyPress);
            // 
            // numeroExemplar
            // 
            this.numeroExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numeroExemplar.Location = new System.Drawing.Point(951, 16);
            this.numeroExemplar.Name = "numeroExemplar";
            this.numeroExemplar.Size = new System.Drawing.Size(59, 20);
            this.numeroExemplar.TabIndex = 11;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.volume.Location = new System.Drawing.Point(951, 41);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(59, 20);
            this.volume.TabIndex = 12;
            // 
            // anoEdicao
            // 
            this.anoEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.anoEdicao.Location = new System.Drawing.Point(951, 66);
            this.anoEdicao.Name = "anoEdicao";
            this.anoEdicao.Size = new System.Drawing.Size(59, 20);
            this.anoEdicao.TabIndex = 13;
            // 
            // idioma
            // 
            this.idioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.idioma.Location = new System.Drawing.Point(1286, 67);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(121, 20);
            this.idioma.TabIndex = 16;
            this.idioma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idioma_KeyPress);
            // 
            // secao
            // 
            this.secao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.secao.Location = new System.Drawing.Point(1286, 41);
            this.secao.Name = "secao";
            this.secao.Size = new System.Drawing.Size(121, 20);
            this.secao.TabIndex = 15;
            // 
            // localizacao
            // 
            this.localizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.localizacao.Location = new System.Drawing.Point(1286, 13);
            this.localizacao.Name = "localizacao";
            this.localizacao.Size = new System.Drawing.Size(59, 20);
            this.localizacao.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.DisplayMember = "text";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.comboBox1.Location = new System.Drawing.Point(510, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // codAutor
            // 
            this.codAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.codAutor.Location = new System.Drawing.Point(126, 90);
            this.codAutor.Name = "codAutor";
            this.codAutor.Size = new System.Drawing.Size(45, 20);
            this.codAutor.TabIndex = 5;
            this.codAutor.Leave += new System.EventHandler(this.codAutor_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(8, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Código do Autor";
            // 
            // codEditora
            // 
            this.codEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.codEditora.Location = new System.Drawing.Point(511, 14);
            this.codEditora.Name = "codEditora";
            this.codEditora.Size = new System.Drawing.Size(45, 20);
            this.codEditora.TabIndex = 7;
            this.codEditora.Leave += new System.EventHandler(this.codEditora_Leave);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(387, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Código da Editora";
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Location = new System.Drawing.Point(193, 92);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(0, 13);
            this.labelNomeAutor.TabIndex = 39;
            // 
            // btnPesquisaEditora
            // 
            this.btnPesquisaEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPesquisaEditora.AutoSize = true;
            this.btnPesquisaEditora.Location = new System.Drawing.Point(578, 21);
            this.btnPesquisaEditora.Name = "btnPesquisaEditora";
            this.btnPesquisaEditora.Size = new System.Drawing.Size(0, 13);
            this.btnPesquisaEditora.TabIndex = 40;
            // 
            // btnPesquisaLocal
            // 
            this.btnPesquisaLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPesquisaLocal.Location = new System.Drawing.Point(174, 64);
            this.btnPesquisaLocal.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnPesquisaLocal.Name = "btnPesquisaLocal";
            this.btnPesquisaLocal.Size = new System.Drawing.Size(19, 20);
            this.btnPesquisaLocal.TabIndex = 4;
            this.btnPesquisaLocal.Text = "🔎";
            this.btnPesquisaLocal.UseVisualStyleBackColor = true;
            this.btnPesquisaLocal.Click += new System.EventHandler(this.btnPesquisaLocal_Click);
            // 
            // btnPesquisaAutor
            // 
            this.btnPesquisaAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPesquisaAutor.Location = new System.Drawing.Point(174, 90);
            this.btnPesquisaAutor.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnPesquisaAutor.Name = "btnPesquisaAutor";
            this.btnPesquisaAutor.Size = new System.Drawing.Size(19, 20);
            this.btnPesquisaAutor.TabIndex = 6;
            this.btnPesquisaAutor.Text = "🔎";
            this.btnPesquisaAutor.UseVisualStyleBackColor = true;
            this.btnPesquisaAutor.Click += new System.EventHandler(this.btnPesquisaAutor_Click);
            // 
            // labelCodLocal
            // 
            this.labelCodLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCodLocal.AutoSize = true;
            this.labelCodLocal.Location = new System.Drawing.Point(193, 68);
            this.labelCodLocal.Name = "labelCodLocal";
            this.labelCodLocal.Size = new System.Drawing.Size(0, 13);
            this.labelCodLocal.TabIndex = 38;
            this.labelCodLocal.Click += new System.EventHandler(this.labelCodLocal_Click);
            // 
            // btnPesquisaEditor
            // 
            this.btnPesquisaEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPesquisaEditor.Location = new System.Drawing.Point(562, 15);
            this.btnPesquisaEditor.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnPesquisaEditor.Name = "btnPesquisaEditor";
            this.btnPesquisaEditor.Size = new System.Drawing.Size(19, 20);
            this.btnPesquisaEditor.TabIndex = 8;
            this.btnPesquisaEditor.Text = "🔎";
            this.btnPesquisaEditor.UseVisualStyleBackColor = true;
            this.btnPesquisaEditor.Click += new System.EventHandler(this.btnPesquisaEditor_Click);
            // 
            // CadAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 408);
            this.Controls.Add(this.btnPesquisaEditor);
            this.Controls.Add(this.btnPesquisaAutor);
            this.Controls.Add(this.btnPesquisaLocal);
            this.Controls.Add(this.btnPesquisaEditora);
            this.Controls.Add(this.labelNomeAutor);
            this.Controls.Add(this.labelCodLocal);
            this.Controls.Add(this.codEditora);
            this.Controls.Add(this.codAutor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.localizacao);
            this.Controls.Add(this.secao);
            this.Controls.Add(this.idioma);
            this.Controls.Add(this.anoEdicao);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.numeroExemplar);
            this.Controls.Add(this.nomeColecao);
            this.Controls.Add(this.nomeAcervo);
            this.Controls.Add(this.codLocal);
            this.Controls.Add(this.codItem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteAcervo);
            this.Controls.Add(this.saveAcervo);
            this.Controls.Add(this.label16);
            this.MinimumSize = new System.Drawing.Size(1566, 447);
            this.Name = "CadAcervo";
            this.Text = "Cadastro do Acervo";
            this.Load += new System.EventHandler(this.CadAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAcervo;
        private System.Windows.Forms.Button deleteAcervo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox codItem;
        private System.Windows.Forms.TextBox codLocal;
        private System.Windows.Forms.TextBox nomeAcervo;
        private System.Windows.Forms.TextBox nomeColecao;
        private System.Windows.Forms.TextBox numeroExemplar;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.TextBox anoEdicao;
        private System.Windows.Forms.TextBox idioma;
        private System.Windows.Forms.TextBox secao;
        private System.Windows.Forms.TextBox localizacao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox codAutor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox codEditora;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelNomeAutor;
        private System.Windows.Forms.Label btnPesquisaEditora;
        private System.Windows.Forms.Button btnPesquisaLocal;
        private System.Windows.Forms.Button btnPesquisaAutor;
        private System.Windows.Forms.Label labelCodLocal;
        private System.Windows.Forms.Button btnPesquisaEditor;
    }
}
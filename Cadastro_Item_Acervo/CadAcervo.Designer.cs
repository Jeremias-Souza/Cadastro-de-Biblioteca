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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.nomeLocal = new System.Windows.Forms.TextBox();
            this.nomeAutor = new System.Windows.Forms.TextBox();
            this.nomeEditora = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveAcervo
            // 
            this.saveAcervo.Location = new System.Drawing.Point(259, 218);
            this.saveAcervo.Name = "saveAcervo";
            this.saveAcervo.Size = new System.Drawing.Size(75, 23);
            this.saveAcervo.TabIndex = 0;
            this.saveAcervo.Text = "Salvar";
            this.saveAcervo.UseVisualStyleBackColor = true;
            this.saveAcervo.Click += new System.EventHandler(this.saveAcervo_Click);
            // 
            // deleteAcervo
            // 
            this.deleteAcervo.Location = new System.Drawing.Point(368, 218);
            this.deleteAcervo.Name = "deleteAcervo";
            this.deleteAcervo.Size = new System.Drawing.Size(75, 23);
            this.deleteAcervo.TabIndex = 1;
            this.deleteAcervo.Text = "Excluir";
            this.deleteAcervo.UseVisualStyleBackColor = true;
            this.deleteAcervo.Click += new System.EventHandler(this.deleteAcervo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 157);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código do Acervo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Acervo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código do Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome do Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome da Editora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(326, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome da Coleção";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(326, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo do Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(326, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Número do Exemplar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(326, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Volume";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(326, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ano da Edição";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(326, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Código da prateleira";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(326, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Seção";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(326, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Idioma";
            // 
            // codItem
            // 
            this.codItem.Enabled = false;
            this.codItem.Location = new System.Drawing.Point(120, 6);
            this.codItem.Name = "codItem";
            this.codItem.Size = new System.Drawing.Size(45, 20);
            this.codItem.TabIndex = 20;
            // 
            // codLocal
            // 
            this.codLocal.Location = new System.Drawing.Point(120, 57);
            this.codLocal.Name = "codLocal";
            this.codLocal.Size = new System.Drawing.Size(45, 20);
            this.codLocal.TabIndex = 21;
            // 
            // nomeAcervo
            // 
            this.nomeAcervo.Location = new System.Drawing.Point(120, 32);
            this.nomeAcervo.Multiline = true;
            this.nomeAcervo.Name = "nomeAcervo";
            this.nomeAcervo.Size = new System.Drawing.Size(188, 20);
            this.nomeAcervo.TabIndex = 22;
            this.nomeAcervo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeAcervo_KeyPress);
            // 
            // nomeLocal
            // 
            this.nomeLocal.Location = new System.Drawing.Point(120, 82);
            this.nomeLocal.Multiline = true;
            this.nomeLocal.Name = "nomeLocal";
            this.nomeLocal.Size = new System.Drawing.Size(188, 20);
            this.nomeLocal.TabIndex = 23;
            this.nomeLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeLocal_KeyPress);
            // 
            // nomeAutor
            // 
            this.nomeAutor.Location = new System.Drawing.Point(120, 108);
            this.nomeAutor.Name = "nomeAutor";
            this.nomeAutor.Size = new System.Drawing.Size(188, 20);
            this.nomeAutor.TabIndex = 24;
            this.nomeAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeAutor_KeyPress);
            // 
            // nomeEditora
            // 
            this.nomeEditora.Location = new System.Drawing.Point(120, 164);
            this.nomeEditora.Name = "nomeEditora";
            this.nomeEditora.Size = new System.Drawing.Size(188, 20);
            this.nomeEditora.TabIndex = 25;
            this.nomeEditora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeEditora_KeyPress);
            // 
            // nomeColecao
            // 
            this.nomeColecao.Location = new System.Drawing.Point(464, 5);
            this.nomeColecao.Name = "nomeColecao";
            this.nomeColecao.Size = new System.Drawing.Size(188, 20);
            this.nomeColecao.TabIndex = 26;
            this.nomeColecao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nomeColecao_MouseClick);
            this.nomeColecao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeColecao_KeyPress);
            // 
            // numeroExemplar
            // 
            this.numeroExemplar.Location = new System.Drawing.Point(464, 57);
            this.numeroExemplar.Name = "numeroExemplar";
            this.numeroExemplar.Size = new System.Drawing.Size(100, 20);
            this.numeroExemplar.TabIndex = 28;
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(464, 82);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(100, 20);
            this.volume.TabIndex = 29;
            // 
            // anoEdicao
            // 
            this.anoEdicao.Location = new System.Drawing.Point(464, 107);
            this.anoEdicao.Name = "anoEdicao";
            this.anoEdicao.Size = new System.Drawing.Size(100, 20);
            this.anoEdicao.TabIndex = 30;
            // 
            // idioma
            // 
            this.idioma.Location = new System.Drawing.Point(464, 188);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(188, 20);
            this.idioma.TabIndex = 31;
            this.idioma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idioma_KeyPress);
            // 
            // secao
            // 
            this.secao.Location = new System.Drawing.Point(464, 162);
            this.secao.Name = "secao";
            this.secao.Size = new System.Drawing.Size(188, 20);
            this.secao.TabIndex = 32;
            // 
            // localizacao
            // 
            this.localizacao.Location = new System.Drawing.Point(464, 134);
            this.localizacao.Name = "localizacao";
            this.localizacao.Size = new System.Drawing.Size(188, 20);
            this.localizacao.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "text";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.comboBox1.Location = new System.Drawing.Point(464, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "Selecione";
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // codAutor
            // 
            this.codAutor.Location = new System.Drawing.Point(121, 135);
            this.codAutor.Name = "codAutor";
            this.codAutor.Size = new System.Drawing.Size(188, 20);
            this.codAutor.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(7, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Código do Autor";
            // 
            // codEditora
            // 
            this.codEditora.Location = new System.Drawing.Point(120, 192);
            this.codEditora.Name = "codEditora";
            this.codEditora.Size = new System.Drawing.Size(188, 20);
            this.codEditora.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(6, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Código da Editora";
            // 
            // CadAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 408);
            this.Controls.Add(this.codEditora);
            this.Controls.Add(this.label16);
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
            this.Controls.Add(this.nomeEditora);
            this.Controls.Add(this.nomeAutor);
            this.Controls.Add(this.nomeLocal);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteAcervo);
            this.Controls.Add(this.saveAcervo);
            this.Name = "CadAcervo";
            this.Text = "Cadastro do Acervo";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox nomeLocal;
        private System.Windows.Forms.TextBox nomeAutor;
        private System.Windows.Forms.TextBox nomeEditora;
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
    }
}
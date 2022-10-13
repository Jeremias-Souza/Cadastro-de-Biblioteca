namespace Cadastro_Leitor
{
    partial class CadLeitor
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
            this.telefone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.enderecoUF = new System.Windows.Forms.TextBox();
            this.enderecoNumero = new System.Windows.Forms.TextBox();
            this.enderecoCEP = new System.Windows.Forms.TextBox();
            this.enderecoNome = new System.Windows.Forms.TextBox();
            this.enderecoBairro = new System.Windows.Forms.TextBox();
            this.telefoneCelular = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.codLeitor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteLeitor = new System.Windows.Forms.Button();
            this.saveLeitor = new System.Windows.Forms.Button();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.enderecoCidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(137, 191);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(132, 20);
            this.telefone.TabIndex = 8;
            this.telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefone_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(9, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 17);
            this.label16.TabIndex = 72;
            this.label16.Text = "Telefone";
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(138, 134);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(82, 20);
            this.rg.TabIndex = 6;
            this.rg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rg_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(10, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 17);
            this.label15.TabIndex = 70;
            this.label15.Text = "RG";
            // 
            // enderecoUF
            // 
            this.enderecoUF.Location = new System.Drawing.Point(540, 165);
            this.enderecoUF.Name = "enderecoUF";
            this.enderecoUF.Size = new System.Drawing.Size(36, 20);
            this.enderecoUF.TabIndex = 15;
            this.enderecoUF.TextChanged += new System.EventHandler(this.enderecoUF_TextChanged);
            this.enderecoUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enderecoUF_KeyPress);
            // 
            // enderecoNumero
            // 
            this.enderecoNumero.Location = new System.Drawing.Point(540, 113);
            this.enderecoNumero.Name = "enderecoNumero";
            this.enderecoNumero.Size = new System.Drawing.Size(50, 20);
            this.enderecoNumero.TabIndex = 13;
            this.enderecoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enderecoNumero_KeyPress);
            // 
            // enderecoCEP
            // 
            this.enderecoCEP.Location = new System.Drawing.Point(540, 139);
            this.enderecoCEP.Name = "enderecoCEP";
            this.enderecoCEP.Size = new System.Drawing.Size(100, 20);
            this.enderecoCEP.TabIndex = 14;
            this.enderecoCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enderecoCEP_KeyPress);
            // 
            // enderecoNome
            // 
            this.enderecoNome.Location = new System.Drawing.Point(541, 87);
            this.enderecoNome.Name = "enderecoNome";
            this.enderecoNome.Size = new System.Drawing.Size(154, 20);
            this.enderecoNome.TabIndex = 12;
            // 
            // enderecoBairro
            // 
            this.enderecoBairro.Location = new System.Drawing.Point(541, 61);
            this.enderecoBairro.Name = "enderecoBairro";
            this.enderecoBairro.Size = new System.Drawing.Size(154, 20);
            this.enderecoBairro.TabIndex = 11;
            // 
            // telefoneCelular
            // 
            this.telefoneCelular.Location = new System.Drawing.Point(540, 6);
            this.telefoneCelular.Name = "telefoneCelular";
            this.telefoneCelular.Size = new System.Drawing.Size(132, 20);
            this.telefoneCelular.TabIndex = 9;
            this.telefoneCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefoneCelular_KeyPress);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(137, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(188, 20);
            this.email.TabIndex = 7;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(137, 107);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(83, 20);
            this.cpf.TabIndex = 5;
            this.cpf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cpf_MouseClick);
            this.cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpf_KeyPress);
            // 
            // dataNascimento
            // 
            this.dataNascimento.Location = new System.Drawing.Point(137, 81);
            this.dataNascimento.Multiline = true;
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(83, 20);
            this.dataNascimento.TabIndex = 4;
            this.dataNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataNascimento_KeyPress);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(137, 31);
            this.nome.Multiline = true;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(188, 20);
            this.nome.TabIndex = 2;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            this.nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nome_KeyPress);
            // 
            // codLeitor
            // 
            this.codLeitor.Enabled = false;
            this.codLeitor.Location = new System.Drawing.Point(137, 5);
            this.codLeitor.Name = "codLeitor";
            this.codLeitor.Size = new System.Drawing.Size(45, 20);
            this.codLeitor.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(426, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = "Número";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(425, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "UF (Estado)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(425, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(425, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Rua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(425, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(425, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(425, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Telefone Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Código do Leitor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 157);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deleteLeitor
            // 
            this.deleteLeitor.Location = new System.Drawing.Point(418, 216);
            this.deleteLeitor.Name = "deleteLeitor";
            this.deleteLeitor.Size = new System.Drawing.Size(75, 23);
            this.deleteLeitor.TabIndex = 17;
            this.deleteLeitor.Text = "Excluir";
            this.deleteLeitor.UseVisualStyleBackColor = true;
            this.deleteLeitor.Click += new System.EventHandler(this.deleteLeitor_Click);
            // 
            // saveLeitor
            // 
            this.saveLeitor.Location = new System.Drawing.Point(294, 216);
            this.saveLeitor.Name = "saveLeitor";
            this.saveLeitor.Size = new System.Drawing.Size(75, 23);
            this.saveLeitor.TabIndex = 16;
            this.saveLeitor.Text = "Salvar";
            this.saveLeitor.UseVisualStyleBackColor = true;
            this.saveLeitor.Click += new System.EventHandler(this.saveLeitor_Click);
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexo.Location = new System.Drawing.Point(137, 56);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 3;
            this.sexo.SelectedIndexChanged += new System.EventHandler(this.sexo_SelectedIndexChanged);
            this.sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sexo_KeyPress);
            // 
            // enderecoCidade
            // 
            this.enderecoCidade.Location = new System.Drawing.Point(540, 34);
            this.enderecoCidade.Name = "enderecoCidade";
            this.enderecoCidade.Size = new System.Drawing.Size(155, 20);
            this.enderecoCidade.TabIndex = 10;
            this.enderecoCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enderecoCidade_KeyPress);
            // 
            // CadLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 408);
            this.Controls.Add(this.enderecoCidade);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.enderecoUF);
            this.Controls.Add(this.enderecoNumero);
            this.Controls.Add(this.enderecoCEP);
            this.Controls.Add(this.enderecoNome);
            this.Controls.Add(this.enderecoBairro);
            this.Controls.Add(this.telefoneCelular);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codLeitor);
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
            this.Controls.Add(this.deleteLeitor);
            this.Controls.Add(this.saveLeitor);
            this.MinimumSize = new System.Drawing.Size(748, 447);
            this.Name = "CadLeitor";
            this.Text = "Cadastro do Leitor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox enderecoUF;
        private System.Windows.Forms.TextBox enderecoNumero;
        private System.Windows.Forms.TextBox enderecoCEP;
        private System.Windows.Forms.TextBox enderecoNome;
        private System.Windows.Forms.TextBox enderecoBairro;
        private System.Windows.Forms.TextBox telefoneCelular;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.TextBox dataNascimento;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox codLeitor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteLeitor;
        private System.Windows.Forms.Button saveLeitor;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.TextBox enderecoCidade;
    }
}
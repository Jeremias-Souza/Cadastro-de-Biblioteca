namespace Cadastro_Editora
{
    partial class CadEditora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEditora));
            this.saveEditora = new System.Windows.Forms.Button();
            this.deleteEditora = new System.Windows.Forms.Button();
            this.codeEditora = new System.Windows.Forms.TextBox();
            this.nomeEditora = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveEditora
            // 
            this.saveEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveEditora.Location = new System.Drawing.Point(606, 75);
            this.saveEditora.MaximumSize = new System.Drawing.Size(75, 23);
            this.saveEditora.MinimumSize = new System.Drawing.Size(75, 23);
            this.saveEditora.Name = "saveEditora";
            this.saveEditora.Size = new System.Drawing.Size(75, 23);
            this.saveEditora.TabIndex = 3;
            this.saveEditora.Text = "Salvar";
            this.saveEditora.UseVisualStyleBackColor = true;
            this.saveEditora.Click += new System.EventHandler(this.saveEditora_Click);
            // 
            // deleteEditora
            // 
            this.deleteEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteEditora.Location = new System.Drawing.Point(696, 75);
            this.deleteEditora.MaximumSize = new System.Drawing.Size(75, 23);
            this.deleteEditora.MinimumSize = new System.Drawing.Size(75, 23);
            this.deleteEditora.Name = "deleteEditora";
            this.deleteEditora.Size = new System.Drawing.Size(75, 23);
            this.deleteEditora.TabIndex = 4;
            this.deleteEditora.Text = "Excluir";
            this.deleteEditora.UseVisualStyleBackColor = true;
            this.deleteEditora.Click += new System.EventHandler(this.deleteEditora_Click);
            // 
            // codeEditora
            // 
            this.codeEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.codeEditora.Enabled = false;
            this.codeEditora.Location = new System.Drawing.Point(687, 8);
            this.codeEditora.MaximumSize = new System.Drawing.Size(82, 20);
            this.codeEditora.Name = "codeEditora";
            this.codeEditora.Size = new System.Drawing.Size(50, 20);
            this.codeEditora.TabIndex = 1;
            // 
            // nomeEditora
            // 
            this.nomeEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nomeEditora.Location = new System.Drawing.Point(687, 34);
            this.nomeEditora.MaximumSize = new System.Drawing.Size(120, 20);
            this.nomeEditora.Name = "nomeEditora";
            this.nomeEditora.Size = new System.Drawing.Size(120, 20);
            this.nomeEditora.TabIndex = 2;
            this.nomeEditora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeEditora_KeyPress);
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
            this.dataGridView1.Location = new System.Drawing.Point(570, 110);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(237, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(237, 233);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(567, 9);
            this.label2.MaximumSize = new System.Drawing.Size(121, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código da editora:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(567, 35);
            this.label1.MaximumSize = new System.Drawing.Size(114, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome da editora:";
            // 
            // CadEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nomeEditora);
            this.Controls.Add(this.codeEditora);
            this.Controls.Add(this.deleteEditora);
            this.Controls.Add(this.saveEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "CadEditora";
            this.Text = "Cadastro da Editora";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveEditora;
        private System.Windows.Forms.Button deleteEditora;
        private System.Windows.Forms.TextBox codeEditora;
        private System.Windows.Forms.TextBox nomeEditora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
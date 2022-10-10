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
            this.saveEditora.Location = new System.Drawing.Point(127, 58);
            this.saveEditora.Name = "saveEditora";
            this.saveEditora.Size = new System.Drawing.Size(75, 23);
            this.saveEditora.TabIndex = 0;
            this.saveEditora.Text = "Salvar";
            this.saveEditora.UseVisualStyleBackColor = true;
            this.saveEditora.Click += new System.EventHandler(this.saveEditora_Click);
            // 
            // deleteEditora
            // 
            this.deleteEditora.Location = new System.Drawing.Point(208, 58);
            this.deleteEditora.Name = "deleteEditora";
            this.deleteEditora.Size = new System.Drawing.Size(75, 23);
            this.deleteEditora.TabIndex = 1;
            this.deleteEditora.Text = "Excluir";
            this.deleteEditora.UseVisualStyleBackColor = true;
            this.deleteEditora.Click += new System.EventHandler(this.deleteEditora_Click);
            // 
            // codeEditora
            // 
            this.codeEditora.Enabled = false;
            this.codeEditora.Location = new System.Drawing.Point(127, 6);
            this.codeEditora.Name = "codeEditora";
            this.codeEditora.Size = new System.Drawing.Size(50, 20);
            this.codeEditora.TabIndex = 2;
            // 
            // nomeEditora
            // 
            this.nomeEditora.Location = new System.Drawing.Point(127, 32);
            this.nomeEditora.Name = "nomeEditora";
            this.nomeEditora.Size = new System.Drawing.Size(156, 20);
            this.nomeEditora.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 86);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código da editora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome da editora";
            // 
            // CadEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nomeEditora);
            this.Controls.Add(this.codeEditora);
            this.Controls.Add(this.deleteEditora);
            this.Controls.Add(this.saveEditora);
            this.Controls.Add(this.label2);
            this.Name = "CadEditora";
            this.Text = "CadEditora";
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
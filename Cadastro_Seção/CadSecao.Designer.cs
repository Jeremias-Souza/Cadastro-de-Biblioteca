﻿namespace Cadastro_Seção
{
    partial class CadSecao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descricaoSecao = new System.Windows.Forms.TextBox();
            this.codSecao = new System.Windows.Forms.TextBox();
            this.deleteSecao = new System.Windows.Forms.Button();
            this.saveSecao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(296, 66);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // descricaoSecao
            // 
            this.descricaoSecao.Location = new System.Drawing.Point(132, 30);
            this.descricaoSecao.Multiline = true;
            this.descricaoSecao.Name = "descricaoSecao";
            this.descricaoSecao.Size = new System.Drawing.Size(167, 45);
            this.descricaoSecao.TabIndex = 1;
            // 
            // codSecao
            // 
            this.codSecao.Enabled = false;
            this.codSecao.Location = new System.Drawing.Point(132, 6);
            this.codSecao.Name = "codSecao";
            this.codSecao.Size = new System.Drawing.Size(50, 20);
            this.codSecao.TabIndex = 0;
            // 
            // deleteSecao
            // 
            this.deleteSecao.Location = new System.Drawing.Point(213, 78);
            this.deleteSecao.Name = "deleteSecao";
            this.deleteSecao.Size = new System.Drawing.Size(75, 23);
            this.deleteSecao.TabIndex = 3;
            this.deleteSecao.Text = "Excluir";
            this.deleteSecao.UseVisualStyleBackColor = true;
            this.deleteSecao.Click += new System.EventHandler(this.deleteSecao_Click);
            // 
            // saveSecao
            // 
            this.saveSecao.Location = new System.Drawing.Point(132, 78);
            this.saveSecao.Name = "saveSecao";
            this.saveSecao.Size = new System.Drawing.Size(75, 23);
            this.saveSecao.TabIndex = 2;
            this.saveSecao.Text = "Salvar";
            this.saveSecao.UseVisualStyleBackColor = true;
            this.saveSecao.Click += new System.EventHandler(this.saveSecao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código da Seção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição da Seção";
            // 
            // CadSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 177);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.descricaoSecao);
            this.Controls.Add(this.codSecao);
            this.Controls.Add(this.deleteSecao);
            this.Controls.Add(this.saveSecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "CadSecao";
            this.Text = "CadSecao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox descricaoSecao;
        private System.Windows.Forms.TextBox codSecao;
        private System.Windows.Forms.Button deleteSecao;
        private System.Windows.Forms.Button saveSecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
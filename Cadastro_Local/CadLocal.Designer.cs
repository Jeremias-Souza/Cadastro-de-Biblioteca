namespace Cadastro_Local
{
    partial class CadLocal
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
            this.saveLocal = new System.Windows.Forms.Button();
            this.deleteLocal = new System.Windows.Forms.Button();
            this.descricaoLocal = new System.Windows.Forms.TextBox();
            this.codLocal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveLocal
            // 
            this.saveLocal.Location = new System.Drawing.Point(125, 82);
            this.saveLocal.Name = "saveLocal";
            this.saveLocal.Size = new System.Drawing.Size(75, 23);
            this.saveLocal.TabIndex = 0;
            this.saveLocal.Text = "Salvar";
            this.saveLocal.UseVisualStyleBackColor = true;
            this.saveLocal.Click += new System.EventHandler(this.saveLocal_Click);
            // 
            // deleteLocal
            // 
            this.deleteLocal.Location = new System.Drawing.Point(206, 82);
            this.deleteLocal.Name = "deleteLocal";
            this.deleteLocal.Size = new System.Drawing.Size(75, 23);
            this.deleteLocal.TabIndex = 1;
            this.deleteLocal.Text = "Excluir";
            this.deleteLocal.UseVisualStyleBackColor = true;
            this.deleteLocal.Click += new System.EventHandler(this.deleteLocal_Click);
            // 
            // descricaoLocal
            // 
            this.descricaoLocal.Location = new System.Drawing.Point(125, 38);
            this.descricaoLocal.Multiline = true;
            this.descricaoLocal.Name = "descricaoLocal";
            this.descricaoLocal.Size = new System.Drawing.Size(156, 38);
            this.descricaoLocal.TabIndex = 2;
            // 
            // codLocal
            // 
            this.codLocal.Enabled = false;
            this.codLocal.Location = new System.Drawing.Point(125, 11);
            this.codLocal.Name = "codLocal";
            this.codLocal.Size = new System.Drawing.Size(50, 20);
            this.codLocal.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 61);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código do local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição do local";
            // 
            // CadLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 177);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.codLocal);
            this.Controls.Add(this.descricaoLocal);
            this.Controls.Add(this.deleteLocal);
            this.Controls.Add(this.saveLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CadLocal";
            this.Text = "CadLocal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveLocal;
        private System.Windows.Forms.Button deleteLocal;
        private System.Windows.Forms.TextBox descricaoLocal;
        private System.Windows.Forms.TextBox codLocal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
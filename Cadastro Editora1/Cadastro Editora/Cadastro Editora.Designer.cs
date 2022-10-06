namespace Cadastro_Editora
{
    partial class Editora
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
            this.CodEditora = new System.Windows.Forms.TextBox();
            this.NameEditora = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddEditora = new System.Windows.Forms.Button();
            this.DeleteEditora = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodEditora
            // 
            this.CodEditora.Location = new System.Drawing.Point(203, 42);
            this.CodEditora.Name = "CodEditora";
            this.CodEditora.Size = new System.Drawing.Size(100, 20);
            this.CodEditora.TabIndex = 0;
            // 
            // NameEditora
            // 
            this.NameEditora.Location = new System.Drawing.Point(203, 80);
            this.NameEditora.Name = "NameEditora";
            this.NameEditora.Size = new System.Drawing.Size(100, 20);
            this.NameEditora.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddEditora
            // 
            this.AddEditora.Location = new System.Drawing.Point(203, 125);
            this.AddEditora.Name = "AddEditora";
            this.AddEditora.Size = new System.Drawing.Size(75, 23);
            this.AddEditora.TabIndex = 3;
            this.AddEditora.Text = "button1";
            this.AddEditora.UseVisualStyleBackColor = true;
            this.AddEditora.Click += new System.EventHandler(this.AddEditora_Click);
            // 
            // DeleteEditora
            // 
            this.DeleteEditora.Location = new System.Drawing.Point(203, 154);
            this.DeleteEditora.Name = "DeleteEditora";
            this.DeleteEditora.Size = new System.Drawing.Size(75, 23);
            this.DeleteEditora.TabIndex = 4;
            this.DeleteEditora.Text = "button2";
            this.DeleteEditora.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Editora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteEditora);
            this.Controls.Add(this.AddEditora);
            this.Controls.Add(this.NameEditora);
            this.Controls.Add(this.CodEditora);
            this.Name = "Editora";
            this.Text = "Editora";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodEditora;
        private System.Windows.Forms.TextBox NameEditora;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button AddEditora;
        private System.Windows.Forms.Button DeleteEditora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
namespace Menu
{
    partial class Menu
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
            this.cadastroAutor = new System.Windows.Forms.Button();
            this.cadastroEditora = new System.Windows.Forms.Button();
            this.cadastroLeitor = new System.Windows.Forms.Button();
            this.cadastroLocal = new System.Windows.Forms.Button();
            this.cadastroSecao = new System.Windows.Forms.Button();
            this.cadastroAcervo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastroAutor
            // 
            this.cadastroAutor.Location = new System.Drawing.Point(376, 37);
            this.cadastroAutor.Name = "cadastroAutor";
            this.cadastroAutor.Size = new System.Drawing.Size(75, 23);
            this.cadastroAutor.TabIndex = 0;
            this.cadastroAutor.Text = "Autor";
            this.cadastroAutor.UseVisualStyleBackColor = true;
            this.cadastroAutor.Click += new System.EventHandler(this.cadastroAutor_Click);
            // 
            // cadastroEditora
            // 
            this.cadastroEditora.Location = new System.Drawing.Point(376, 66);
            this.cadastroEditora.Name = "cadastroEditora";
            this.cadastroEditora.Size = new System.Drawing.Size(75, 23);
            this.cadastroEditora.TabIndex = 1;
            this.cadastroEditora.Text = "Editora";
            this.cadastroEditora.UseVisualStyleBackColor = true;
            this.cadastroEditora.Click += new System.EventHandler(this.cadastroEditora_Click);
            // 
            // cadastroLeitor
            // 
            this.cadastroLeitor.Location = new System.Drawing.Point(376, 95);
            this.cadastroLeitor.Name = "cadastroLeitor";
            this.cadastroLeitor.Size = new System.Drawing.Size(75, 23);
            this.cadastroLeitor.TabIndex = 2;
            this.cadastroLeitor.Text = "Leitor";
            this.cadastroLeitor.UseVisualStyleBackColor = true;
            this.cadastroLeitor.Click += new System.EventHandler(this.cadastroLeitor_Click);
            // 
            // cadastroLocal
            // 
            this.cadastroLocal.Location = new System.Drawing.Point(376, 124);
            this.cadastroLocal.Name = "cadastroLocal";
            this.cadastroLocal.Size = new System.Drawing.Size(75, 23);
            this.cadastroLocal.TabIndex = 3;
            this.cadastroLocal.Text = "Local";
            this.cadastroLocal.UseVisualStyleBackColor = true;
            this.cadastroLocal.Click += new System.EventHandler(this.cadastroLocal_Click);
            // 
            // cadastroSecao
            // 
            this.cadastroSecao.Location = new System.Drawing.Point(376, 153);
            this.cadastroSecao.Name = "cadastroSecao";
            this.cadastroSecao.Size = new System.Drawing.Size(75, 23);
            this.cadastroSecao.TabIndex = 4;
            this.cadastroSecao.Text = "Seção";
            this.cadastroSecao.UseVisualStyleBackColor = true;
            this.cadastroSecao.Click += new System.EventHandler(this.cadastroSecao_Click);
            // 
            // cadastroAcervo
            // 
            this.cadastroAcervo.Location = new System.Drawing.Point(376, 182);
            this.cadastroAcervo.Name = "cadastroAcervo";
            this.cadastroAcervo.Size = new System.Drawing.Size(75, 23);
            this.cadastroAcervo.TabIndex = 5;
            this.cadastroAcervo.Text = "Acervo";
            this.cadastroAcervo.UseVisualStyleBackColor = true;
            this.cadastroAcervo.Click += new System.EventHandler(this.cadastroAcervo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadastroAcervo);
            this.Controls.Add(this.cadastroSecao);
            this.Controls.Add(this.cadastroLocal);
            this.Controls.Add(this.cadastroLeitor);
            this.Controls.Add(this.cadastroEditora);
            this.Controls.Add(this.cadastroAutor);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastroAutor;
        private System.Windows.Forms.Button cadastroEditora;
        private System.Windows.Forms.Button cadastroLeitor;
        private System.Windows.Forms.Button cadastroLocal;
        private System.Windows.Forms.Button cadastroSecao;
        private System.Windows.Forms.Button cadastroAcervo;
    }
}
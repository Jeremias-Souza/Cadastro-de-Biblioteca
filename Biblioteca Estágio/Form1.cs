using DnsClient.Protocol;
using Microsoft.Win32;
using Newtonsoft.Json.Converters;
using RazorEngine.Compilation.ImpromptuInterface.InvokeExt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.IO;
using System.Windows.Controls.Primitives;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Controls;
using Control = System.Windows.Forms.Control;
using TextBox = System.Windows.Forms.TextBox;
using System.Globalization;
using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CharacterCasing = System.Windows.Forms.CharacterCasing;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca_Estágio
{
    public partial class CadastroAutor : Form
    {
      

        public CadastroAutor()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT Codigo, Nome, Descricao FROM Cadastro_Autor";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                toolStripStatusLabel1.Text = "Finalizado com sucesso";
                statusStrip1.Refresh();

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha!";
                statusStrip1.Refresh();
                MessageBox.Show("Falha! \n" + ex.Message);

            }

            
        }

        private void AddAutor_Click(object sender, EventArgs e) //Botao para adicionar o autor 
        {

            if (string.IsNullOrEmpty(CodAutor.Text))
            {
                MessageBox.Show("Informe o Código do usuário antes de salvar", "Cadastro.Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(NomeAutor.Text))
            {
                MessageBox.Show("Informe o nome do usuário antes de salvar", "Cadastro.Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                                       
            toolStripStatusLabel1.Text = "Conectando...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                 

                    var sql = "INSERT INTO Cadastro_autor (Codigo, Nome, Descricao, Foto) VALUES (@Código, @Nome, @Descrição, @Foto)"; //Insere na tabela conforme o comando

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        toolStripStatusLabel1.Text = "Salvando.";
                        statusStrip1.Refresh();

                        cmd.Parameters.AddWithValue("@Código", CodAutor.Text);
                        cmd.Parameters.AddWithValue("@Nome", NomeAutor.Text);
                        cmd.Parameters.AddWithValue("@Descrição", InfAutor.Text);
                        cmd.Parameters.AddWithValue("@Foto", pictureBox1);

                        cmd.ExecuteNonQuery();

                        
                    }



                    string sqlQuery = "SELECT Codigo, Nome, Descricao FROM Cadastro_Autor";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                    MessageBox.Show("Cadastro feito com sucesso!"); //Aviso casa seja feito com exito
                    ClearTextBoxes();

                    toolStripStatusLabel1.Text = "Pronto";
                    statusStrip1.Refresh();


                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha"; //Mostra mensagem com o erro caso houver erro
                statusStrip1.Refresh();
                MessageBox.Show("Não Inserir os dados!" + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e) //Botão para deletar autor
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde";
            statusStrip1.Refresh();

            if (MessageBox.Show("Deseja realmente DELETAR o autor? ", "Cadastro autor", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    

                    var sqlQuery = "DELETE Cadastro_autor Where Codigo = '" + CodAutor.Text + "'" + "SELECT Codigo, Nome, Descricao FROM Cadastro_Autor" ;  //Deleta o autor pelo código digitado na caixa de código
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;                                                        
                        }
                    }                 

                }
                
                
                ClearTextBoxes();
                toolStripStatusLabel1.Text = "Finalizado com sucesso"; 
                statusStrip1.Refresh();

            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                toolStripStatusLabel1.Text = "Falha!";
                statusStrip1.Refresh();
                MessageBox.Show("Falha! \n" + ex.Message);

            }
        }
             

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)//Caixa aonde ocorre as atualizações de processos
        {
            toolStripStatusLabel1.Text = "";
        }
       

        private void btnLoadImage_Click(object sender, EventArgs e) //Botao para carregar imagem 
        {
            

        }

         
        private void ClearTextBoxes() //Função para limpar formularios depois de salvar
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                       (control as TextBox).Clear();                        
                    else
                        func(control.Controls);              
            };

            func(Controls);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            CodAutor.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NomeAutor.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            InfAutor.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();            

        }

        private void NomeAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;

            }

        }

        private void NomeAutor_TextChanged(object sender, EventArgs e) //Caixa de texto Nome do autor 
        {
            if (NomeAutor.Text.ToString().Length > 0)
            {
                NomeAutor.Text = char.ToUpper(NomeAutor.Text[0]) + NomeAutor.Text.ToString().Substring(1);
            }

        }

        private void CodAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Buscar_TextChanged(object sender, EventArgs e)//Caixa de texto para pesquisar autor 
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Caixa de imagem
        {           
        }

        private void CodAutor_TextChanged(object sender, EventArgs e) //Caixa de texto código do autor
        {           
            
        }

        
    

        private void InfAutor_TextChanged(object sender, EventArgs e) //Caixa de texto Informações do autor
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
           

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
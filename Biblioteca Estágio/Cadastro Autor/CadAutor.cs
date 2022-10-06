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
using Image = System.Drawing.Image;
using System.Data.SqlTypes;
using AventStack.ExtentReports.Model;
using System.Collections.Immutable;
using System.Data.Common;
using Page = System.Windows.Controls.Page;
using NetTopologySuite.Algorithm;

namespace Biblioteca_Estágio
{
    

    public partial class CadastroAutor : Form
    {
        
        int indexRow;
        public string caminhoFoto = "";
        private Autor autor = new Autor();
        

        


        public CadastroAutor()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT Código, Nome, Descrição FROM Cadastro_Autor";
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

        /*public void Salvar(Autor autor)
        {


            //byte[] foto = GetFoto(autor.CaminhoFoto);

            if (autor.Código != autor.Código)
            {
                var sql = "INSERT INTO Cadastro_autor (Código, Nome, Descrição) VALUES (@Código, @Nome, @Descrição)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@Código", autor.Código);
                        cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                        cmd.Parameters.AddWithValue("@Descrição", autor.Descrição);
                        //cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

            else
            {
                var sql = "UPDATE Cadastro_autor SET Nome = @Nome, Descrição = @Descrição WHERE Código=" + autor.Código;
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                        cmd.Parameters.AddWithValue("@Descrição", autor.Descrição);
                        //cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                        //autor.CaminhoFoto = caminhoFoto;


                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }

            }
        }*/

        private void AddAutor_Click(object sender, EventArgs e) //Botao para adicionar o autor 
        {               

                autor.Código = int.Parse(CodAutor.Text); 
                autor.Nome = NomeAutor.Text;
                autor.Descrição = InfAutor.Text;
                //autor.CaminhoFoto = caminhoFoto;                                   
          

                autor.Salvar(autor);

                MessageBox.Show("Cadastro feito com sucesso!"); //Aviso casa seja feito com exito
                ClearTextBoxes();

                toolStripStatusLabel1.Text = "Pronto";
                statusStrip1.Refresh();

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



                    var sqlQuery = "DELETE Cadastro_autor Where Código = '" + CodAutor.Text + "'" + "SELECT Código, Nome, Descrição FROM Cadastro_Autor";  //Deleta o autor pelo código digitado na caixa de código
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

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT Código, Nome, Descrição FROM Cadastro_Autor";
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


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)//Caixa aonde ocorre as atualizações de processos
        {
            toolStripStatusLabel1.Text = "";
        }


        private void btnLoadImage_Click(object sender, EventArgs e) //Botao para carregar imagem 
        {
           /* var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg e png e jfif |*.jpg; *.png; *.jfif";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK) caminhoFoto = openFile.FileName;

            if (caminhoFoto != "") pictureBox1.Load(caminhoFoto);*/


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

      



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) //Fazer upload nas caixas de texto quando na tabela for apertado duas vezes
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            CodAutor.Text = row.Cells[0].Value.ToString();
            NomeAutor.Text = row.Cells[1].Value.ToString();
            InfAutor.Text = row.Cells[2].Value.ToString();        
        }

       


        private void NomeAutor_KeyPress(object sender, KeyPressEventArgs e) //Aceitar apenas letras na caixa de texto do NomeAutor
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
                NomeAutor.Text = char.ToUpper(NomeAutor.Text[0]) + NomeAutor.Text.ToString().Substring(1); //Transformar a primeira letra maiuscula da escrita na tabela 
            }

        }

        private void CodAutor_KeyPress(object sender, KeyPressEventArgs e) //Poder apenas numeros na tabela de texto CodAutor 
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; 
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

       
        private void pictureBox1_Click(object sender, EventArgs e) //Caixa de imagem
        {           
        }

        private string GeraSequencia(int length)
        {
            Random rnd = new Random();
            string numero = "";

            for (int i = 0; i < length; i++)
            {
                numero += rnd.Next(0, 55);
            }
            return numero.Substring(0, length);
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

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        
    }
}
//using Biblioteca_Estágio;
using Cadastro_Editora;
using Cadastro_Local;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabelas;
using Editora = Tabelas.Editora;
using Local = Tabelas.Local;

namespace Cadastro_Item_Acervo
{
    public partial class CadAcervo : Form
    {
        public int indexRow { get; private set; }
        string[] items = new string[20];

        public CadAcervo()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, descricaoSecao, idioma FROM MvtBibItemAcervo";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }

            this.formatColumns();

        }



        private void saveAcervo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codLocal.Text))
            {
                MessageBox.Show("Código do local é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(numeroExemplar.Text))
            {
                MessageBox.Show("Numero do exemplar é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(codAutor.Text))
            {
                MessageBox.Show("Código do autor é obrigatorio. ");
                return;
            }           
            if (string.IsNullOrWhiteSpace(codEditora.Text))
            {
                MessageBox.Show("Código da editora é obrigatorio. ");
                return;
            }            
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Tipo de item é obrigatorio. ");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(localizacao.Text))
            {
                MessageBox.Show("Código da prateleira é obrigatorio. ");
                return;
            }




            var acervo = new Acervo()
            {

                codLocal = this.codLocal.Text,
                nome = this.nomeAcervo.Text,
                nomeLocal = this.labelCodLocal.Text,
                nomeAutor = this.labelNomeAutor.Text,
                codAutor = this.codAutor.Text,
                nomeEditora = this.labelEditora.Text,
                codEditora = this.codEditora.Text,
                nomeColecao = this.nomeColecao.Text,
                tipoItem = this.comboBox1.Text,
                numExemplar = this.numeroExemplar.Text,
                volume = this.volume.Text,
                anoEdicao = this.anoEdicao.Text,
                localizacao = this.localizacao.Text,
                secao = this.txtSecao.Text,
                descricaoSecao = this.labelSecao.Text,
                idioma = this.idioma.Text,
                codItem = string.IsNullOrEmpty(this.codItem.Text)
                ? 0
                : int.Parse(this.codItem.Text)

            };

            acervo.Salvar();
            MessageBox.Show("Cadastro feito com sucesso!");


            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, descricaoSecao, idioma FROM MvtBibItemAcervo";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                    }
                    ClearTextBoxes();
                }




            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void deleteAcervo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR o Item do Acervo? ", "Cadastro Item do Acervo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();



                    var sqlQuery = "DELETE MvtBibItemAcervo Where codItem = '" + codItem.Text + "'" + "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, descricaoSecao, idioma FROM MvtBibItemAcervo";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }

                MessageBox.Show("Cadastro apagado com sucesso!");
                ClearTextBoxes();



            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {

                MessageBox.Show("Falha! \n" + ex.Message);

            }
        }

        private void formatColumns()
        {

            this.dataGridView1.Columns["codItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["codLocal"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["numExemplar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codEditora"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeEditora"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nomeColecao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["tipoItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nomeLocal"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["Volume"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["anoEdicao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["localizacao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["secao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["descricaoSecao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["idioma"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

             

            this.dataGridView1.Columns["codItem"].HeaderText = "Código Acervo";
            this.dataGridView1.Columns["codLocal"].HeaderText = "Código Local";
            this.dataGridView1.Columns["numExemplar"].HeaderText = "Numero do exemplar";
            this.dataGridView1.Columns["nome"].HeaderText = "Nome";
            this.dataGridView1.Columns["codAutor"].HeaderText = "Código do Autor";
            this.dataGridView1.Columns["nomeAutor"].HeaderText = "Nome do Autor";
            this.dataGridView1.Columns["codEditora"].HeaderText = "Código da Editora";
            this.dataGridView1.Columns["nomeEditora"].HeaderText = "Nome da editora";
            this.dataGridView1.Columns["nomeColecao"].HeaderText = "Nome da coleção";
            this.dataGridView1.Columns["tipoItem"].HeaderText = "Tipo do item";
            this.dataGridView1.Columns["nomeLocal"].HeaderText = "Nome do local";
            this.dataGridView1.Columns["Volume"].HeaderText = "Volume";
            this.dataGridView1.Columns["anoEdicao"].HeaderText = "Ano da edição";
            this.dataGridView1.Columns["localizacao"].HeaderText = "Código Prateleira";
            this.dataGridView1.Columns["secao"].HeaderText = "Seção";
            this.dataGridView1.Columns["descricaoSecao"].HeaderText = "Descrição da seção";
            this.dataGridView1.Columns["idioma"].HeaderText = "Idioma";

                      



        }

        private void ClearTextBoxes() //Função para limpar formularios depois de salvar
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = String.Empty;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).Text= String.Empty;
                    }

            };
            labelEditora.Text = " ";
            labelCodLocal.Text = " ";
            labelNomeAutor.Text = " ";
            comboBox1.Text = " ";
            labelSecao.Text = " ";
            func(Controls);
        }

        

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void nomeAcervo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeColecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void idioma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        

        private void codAutor_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT NomeAutor FROM dbo.MvtBibAutor WHERE codAutor = {int.Parse(this.codAutor.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelNomeAutor.Text = dt.Rows[0].Field<string>("NomeAutor");
                        }
                    }
                }

               
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Autor inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void codEditora_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nome FROM MvtBibEditora WHERE codEditora = {int.Parse(this.codEditora.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelEditora.Text = dt.Rows[0].Field<string>("nome");
                        }
                    }
                }

                
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Editora inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void codLocal_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT descricaoLocal FROM MvtbibLocal WHERE codLocal = {int.Parse(this.codLocal.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelCodLocal.Text = dt.Rows[0].Field<string>("descricaoLocal");
                        }
                    }
                }

            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Local inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void secao_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT descricaoSecao FROM MvtbibSecao WHERE codSecao = {int.Parse(this.txtSecao.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelSecao.Text = dt.Rows[0].Field<string>("descricaoSecao");
                        }
                    }
                }
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Seção inexistente!");
                Console.WriteLine(ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            codItem.Text = $"{row.Cells["codItem"].Value}";
            codLocal.Text = $"{row.Cells["codLocal"].Value}";
            numeroExemplar.Text = $"{row.Cells["numExemplar"].Value}";
            labelCodLocal.Text = $"{row.Cells["nomeLocal"].Value}";
            codAutor.Text = $"{row.Cells["codAutor"].Value}";
            labelNomeAutor.Text = $"{row.Cells["nomeAutor"].Value}";
            codEditora.Text = $"{row.Cells["codEditora"].Value}";
            labelEditora.Text = $"{row.Cells["nomeEditora"].Value}";
            nomeColecao.Text = $"{row.Cells["nomeColecao"].Value}";
            comboBox1.Text = $"{row.Cells["tipoItem"].Value}";
            nomeAcervo.Text = $"{row.Cells["nome"].Value}";
            volume.Text = $"{row.Cells["volume"].Value}";
            anoEdicao.Text = $"{row.Cells["anoEdicao"].Value}";
            localizacao.Text = $"{row.Cells["localizacao"].Value}";
            txtSecao.Text = $"{row.Cells["secao"].Value}";
            idioma.Text = $"{row.Cells["idioma"].Value}";
            labelSecao.Text = $"{row.Cells["descricaoSecao"].Value}";
        }

        private void CadAcervo_Load(object sender, EventArgs e)
        {

        }

        private void nomeColecao_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCodLocal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisaLocal_Click(object sender, EventArgs e)
        {
            Local tela = new Local();
            tela.Show();
        }

        private void btnPesquisaAutor_Click(object sender, EventArgs e)
        {
            Autor tela = new Autor();
            tela.Show();
        }

        private void btnPesquisaEditor_Click(object sender, EventArgs e)
        {
            Editora tela = new Editora();
            tela.Show();
        }

        private void codLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisaSecao_Click(object sender, EventArgs e)
        {
            Secao tela = new Secao();
            tela.Show();
        }

        private void secao_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

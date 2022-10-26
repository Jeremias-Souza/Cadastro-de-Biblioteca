using Cadastro_Item_Acervo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Reserva;

namespace Consulta_Acervo_Item
{
    public partial class ConsultaAcervo : Form
    {
        public int indexRow { get; private set; }

        public ConsultaAcervo()
        {
            InitializeComponent();
            SelectTable();         
        }    
        
        private void SelectTable()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, tipoItem, nome, localizacao, codAutor, nomeAutor, nomeColecao, Secao FROM MvtBibItemAcervo";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    formatColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void txtAutor_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nomeAutor FROM dbo.MvtBibAutor WHERE codAutor = {int.Parse(this.txtAutor.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelAutor.Text = dt.Rows[0].Field<string>("nomeAutor");
                        }
                    }
                }

                MessageBox.Show("Autor Carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Autor inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void txtSecao_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT descricaoSecao FROM dbo.MvtBibSecao WHERE codSecao = {int.Parse(this.txtSecao.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelSecao.Text = dt.Rows[0].Field<string>("descricaoSecao");
                        }
                    }
                }

                MessageBox.Show("Seção Carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seção inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtItem.Text = $"{row.Cells["codItem"].Value}";
            txtNomeItem.Text = $"{row.Cells["nome"].Value}";
            comboTipoItem.Text = $"{row.Cells["tipoItem"].Value}";
            txtLocal.Text = $"{row.Cells["localizacao"].Value}";
            txtAutor.Text = $"{row.Cells["codAutor"].Value}";
            labelAutor.Text = $"{row.Cells["nomeAutor"].Value}";
            txtColecao.Text = $"{row.Cells["nomeColecao"].Value}";
            txtSecao.Text = $"{row.Cells["Secao"].Value}";
        }

        private void formatColumns()
        {
            this.dataGridView1.Columns["codItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["tipoItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["localizacao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nomeColecao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["Secao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codItem"].HeaderText = "Código do Item";
            this.dataGridView1.Columns["nome"].HeaderText = "Nome do Item";
            this.dataGridView1.Columns["tipoItem"].HeaderText = "tipo de item";
            this.dataGridView1.Columns["localizacao"].HeaderText = "Localização";
            this.dataGridView1.Columns["codAutor"].HeaderText = "Código do autor";
            this.dataGridView1.Columns["nomeAutor"].HeaderText = "Nome do autor";
            this.dataGridView1.Columns["nomeColecao"].HeaderText = "Nome da Coleção";
            this.dataGridView1.Columns["Secao"].HeaderText = "Seção";

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            if (txtItem.Text != "")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        var sqlQuery = $"SELECT encerrar FROM dbo.MvtBibReserva WHERE codItem = {int.Parse(this.txtItem.Text)}";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                this.txtstatus.Text = dt.Rows[0].Field<string>("encerrar");
                            }
                        }
                        formatColumns();
                    }
                }
                catch (Exception)
                {
                    txtstatus.Text = "Disponivel";
                }
            }
        }

        private void txtSecao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT descricaoSecao FROM dbo.MvtBibSecao WHERE codSecao = {int.Parse(this.txtSecao.Text)}";
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
            catch (Exception ex)
            {
                MessageBox.Show("Seção inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void txtItem_Leave_1(object sender, EventArgs e)
        {
            if (txtItem.Text != "")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        var sqlQuery = $"SELECT nome, codAutor, nomeAutor, numExemplar, tipoItem, localizacao, secao, nomeColecao FROM dbo.MvtBibItemAcervo WHERE codItem = {int.Parse(this.txtItem.Text)}";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                if (MessageBox.Show("Foram achados registros que correspondem o Código do Item.\r\n\r\nDeseja preenchelos automaticamente?", "Consulta Itens do Acervo", MessageBoxButtons.YesNo) == DialogResult.No)
                                {
                                    return;
                                }

                                this.txtNomeItem.Text = dt.Rows[0].Field<string>("nome");
                                this.txtAutor.Text = dt.Rows[0].Field<int>("codAutor").ToString();
                                this.labelAutor.Text = dt.Rows[0].Field<string>("nomeAutor");
                                this.comboTipoItem.Text = dt.Rows[0].Field<string>("tipoItem");
                                this.txtLocal.Text = dt.Rows[0].Field<string>("localizacao");
                                this.txtSecao.Text = dt.Rows[0].Field<string>("secao");
                                this.txtColecao.Text = dt.Rows[0].Field<string>("nomeColecao");
                            }
                        }
                    }

                    MessageBox.Show("Item Carregado com sucesso!");
                }

                catch (Exception ex) //Mostra mensagem caso haver falha 
                {
                    MessageBox.Show("Item inexistente!");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Item tela = new Item();
            tela.Show();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            Autor tela = new Autor();
            tela.Show();
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            Coleção tela = new Coleção();
            tela.Show();
        }

        private void btnSecao_Click(object sender, EventArgs e)
        {
            Secao tela = new Secao();
            tela.Show();
        }
    }
}

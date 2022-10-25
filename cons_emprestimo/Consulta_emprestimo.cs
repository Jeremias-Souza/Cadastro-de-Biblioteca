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
using cons_emprestimo;

namespace cons_emprestimo
{
    public partial class Consulta_emprestimo : Form
    {
        public int indexRow { get; private set; }

        public Consulta_emprestimo()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar, numReserva FROM MvtBibReserva WHERE encerrar = 'Reservado'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    //ClearTextBoxes();
                }
                this.formatColumns();

            }




            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }
        
        private void txtNomeItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void formatColumns()
        {
            this.dataGridView1.Columns["codItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numExemplar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["tipoItem"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["localizacao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codLeitor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeLeitor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataReserva"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["prazoReserva"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numReserva"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["encerrar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["codItem"].HeaderText = "Código do Item";
            this.dataGridView1.Columns["nomeItem"].HeaderText = "Nome do Item";
            this.dataGridView1.Columns["numExemplar"].HeaderText = "Número do exemplar";
            this.dataGridView1.Columns["tipoItem"].HeaderText = "Tipo do item";
            this.dataGridView1.Columns["localizacao"].HeaderText = "Localização";
            this.dataGridView1.Columns["codLeitor"].HeaderText = "Código do leitor";
            this.dataGridView1.Columns["nomeLeitor"].HeaderText = "Nome do leitor";
            this.dataGridView1.Columns["dataReserva"].HeaderText = "Data da reserva";
            this.dataGridView1.Columns["prazoReserva"].HeaderText = "Data para devolução";
            this.dataGridView1.Columns["numReserva"].HeaderText = "Número da reserva";
            this.dataGridView1.Columns["encerrar"].HeaderText = "Reservado";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
           
            txtItem.Text = $"{row.Cells["codItem"].Value}";
            comboTipoItem.Text = $"{row.Cells["tipoItem"].Value}";
            txtLocal.Text = $"{row.Cells["localizacao"].Value}";
            txtNomeLeitor.Text = $"{row.Cells["codLeitor"].Value}";
            labelLeitor.Text = $"{row.Cells["nomeLeitor"].Value}";
            txtDataReserva.Text = $"{row.Cells["dataReserva"].Value}";
            txtDataFinal.Text = $"{row.Cells["prazoReserva"].Value}";
            comboSituacao.Text = $"{row.Cells["encerrar"].Value}";
            txtNumReserva.Text = $"{row.Cells["numReserva"].Value}";

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Item tela = new Item();
            tela.Show();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Local tela = new Local();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leitor tela = new Leitor();
            tela.Show();
        }

        private void btnSecao_Click(object sender, EventArgs e)
        {
            Secao tela = new Secao();
            tela.Show();
        }

        private void txtNomeLeitor_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nome FROM dbo.MvtBibLeitor WHERE codLeitor = {int.Parse(this.txtNomeLeitor.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelNomeLeitor.Text = dt.Rows[0].Field<string>("nome");
                        }
                    }
                }

                MessageBox.Show("Leitor Carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Leitor inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void txtNumReserva_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtNumReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumReserva_Leave(object sender, EventArgs e)
        {
            
        }

        private void Consulta_emprestimo_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using TextBox = System.Windows.Forms.TextBox;

namespace Reserva
{
    public partial class CadReserva : Form
    {
        public int indexRow { get; private set; }
        
        public CadReserva()
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

                    string sqlQuery = "SELECT codItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar, numReserva FROM MvtBibReserva";
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
                this.formatColumns();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codItem.Text))
            {
                MessageBox.Show("Código do item é obrigatorio. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(nomeItem.Text))
            {
                MessageBox.Show("Nome do item é obrigatorio. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(numExemplar.Text))
            {
                MessageBox.Show("Número do exemplar é obrigatorio. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(tipoItem.Text))
            {
                MessageBox.Show("Tipo do item é obrigatorio. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(localizacao.Text))
            {
                MessageBox.Show("Localização do item é obrigatorio. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(codLeitor.Text))
            {
                MessageBox.Show("Código do leitor é obrigatorio. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(nomeLeitor.Text))
            {
                MessageBox.Show("Nome do leitor é obrigatorio. ");
                return;
            }
           
            //public static byte ToByte(string? value);

            var reserva = new Reservaa()
            {
                codItem = this.codItem.Text,
                situacao = this.intencao.Text,
                nomeItem = this.nomeItem.Text,
                numExemplar = this.numExemplar.Text,
                tipoItem = this.tipoItem.Text,
                localizacao = this.localizacao.Text,
                codLeitor = this.codLeitor.Text,
                nomeLeitor = this.nomeLeitor.Text,
                dataReserva = this.dataReserva.Text,
                prazoReserva = this.prazoReserva.Text,                
                encerrar = this.situacao.Text,               
                numReserva = string.IsNullOrEmpty(this.txtNumReserva.Text)
                ? 0
                : int.Parse(this.txtNumReserva.Text)
            };

            if (intencao.Text == "Devolver")
            {
                devolver();
                MessageBox.Show("Devolução feita com exito!");
                ClearTextBoxes();
                return;
            }
        
            else
            {
                reserva.Salvar(reserva);
                this.formatColumns();
                //MessageBox.Show("Cadastro feito com sucesso!");
            }

            SelectTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "DELETE MvtBibReserva Where numReserva = '" + txtNumReserva.Text + "'" + "SELECT codItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar, numReserva FROM MvtBibReserva";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                        ClearTextBoxes();
                        this.formatColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void devolver()
        {
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();

                var sqlQuery = "DELETE MvtBibReserva Where numReserva = '" + txtNumReserva.Text + "'" + "SELECT codItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar, numReserva FROM MvtBibReserva";
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

            this.dataGridView1.Columns["encerrar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numReserva"]
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
            this.dataGridView1.Columns["encerrar"].HeaderText = "Situação";
            this.dataGridView1.Columns["numReserva"].HeaderText = "Número da reserva";
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
            intencao.Text = " ";
            situacao.Text = " ";
            func(Controls);
        }

        private void dataReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 2 || i.Text.Length == 5)
                    i.Text += "/";
                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void prazoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 2 || i.Text.Length == 5)
                    i.Text += "/";
                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void codItem_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nome, numExemplar, tipoItem, localizacao FROM dbo.MvtBibItemAcervo WHERE codItem = {int.Parse(this.codItem.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.nomeItem.Text = dt.Rows[0].Field<string>("nome");
                            this.numExemplar.Text = dt.Rows[0].Field<int>("numExemplar").ToString();
                            this.tipoItem.Text = dt.Rows[0].Field<string>("tipoItem");
                            this.localizacao.Text = dt.Rows[0].Field<string>("localizacao");
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

        private void codLeitor_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nome FROM dbo.MvtBibLeitor WHERE codLeitor = {int.Parse(this.codLeitor.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.nomeLeitor.Text = dt.Rows[0].Field<string>("nome");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            codItem.Text = $"{row.Cells["codItem"].Value}";
            //intencao.Text = $"{row.Cells["situacao"].Value}";
            nomeItem.Text = $"{row.Cells["nomeItem"].Value}";
            numExemplar.Text = $"{row.Cells["numExemplar"].Value}";
            tipoItem.Text = $"{row.Cells["tipoItem"].Value}";
            localizacao.Text = $"{row.Cells["localizacao"].Value}";
            codLeitor.Text = $"{row.Cells["codLeitor"].Value}";
            nomeLeitor.Text = $"{row.Cells["nomeLeitor"].Value}";
            dataReserva.Text = $"{row.Cells["dataReserva"].Value}";
            prazoReserva.Text = $"{row.Cells["prazoReserva"].Value}";
            situacao.Text = $"{row.Cells["encerrar"].Value}";
            txtNumReserva.Text = $"{row.Cells["numReserva"].Value}";
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Item tela = new Item();
            tela.Show();
        }
    }
}

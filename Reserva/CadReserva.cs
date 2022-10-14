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

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar FROM MvtBibReserva";
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

            
            

            

            var reserva = new Reservaa()
            {

                situacao = this.intencao.Text,
                nomeItem = this.nomeItem.Text,
                numExemplar = this.numExemplar.Text,
                tipoItem = this.tipoItem.Text,
                localizacao = this.localizacao.Text,
                codLeitor = this.codLeitor.Text,
                nomeLeitor = this.nomeLeitor.Text,
                dataReserva = this.dataReserva.Text,
                prazoReserva = this.prazoReserva.Text,                
                encerrar = this.situacao.Text = Boolean.TrueString,               
                codItem = string.IsNullOrEmpty(this.codItem.Text)
                ? 0
                : int.Parse(this.codItem.Text)

            

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
                
                reserva.Salvar();
                this.formatColumns();
                MessageBox.Show("Cadastro feito com sucesso!");
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar FROM MvtBibReserva";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    ClearTextBoxes();
                    this.formatColumns();
                }


            } 




            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        

        

       
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja confirmar a devolução? ", "Reserva de livros", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();



                    var sqlQuery = "DELETE MvtBibReserva Where codItem = '" + codItem.Text + "'" + "SELECT nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva FROM MvtBibReserva";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }

                MessageBox.Show("Reserva apagada com sucesso!");
                ClearTextBoxes();



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



                var sqlQuery = "DELETE MvtBibReserva Where codItem = '" + codItem.Text + "'" + "SELECT nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva FROM MvtBibReserva";
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
            this.dataGridView1.Columns[0]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[1]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[2]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[3]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[4]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[5]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[6]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[7]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[8]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[9]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.Columns[10]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[0].HeaderText = "Movimento";
            this.dataGridView1.Columns[1].HeaderText = "Código do Item";
            this.dataGridView1.Columns[2].HeaderText = "Nome do Item";
            this.dataGridView1.Columns[3].HeaderText = "Número do exemplar";
            this.dataGridView1.Columns[4].HeaderText = "Tipo do item";
            this.dataGridView1.Columns[5].HeaderText = "Localização";
            this.dataGridView1.Columns[6].HeaderText = "Código do leitor";
            this.dataGridView1.Columns[7].HeaderText = "Nome do leitor";
            this.dataGridView1.Columns[8].HeaderText = "Data da reserva";
            this.dataGridView1.Columns[9].HeaderText = "Data para devolução";
            this.dataGridView1.Columns[10].HeaderText = "Reserva";

        }

        private void Reserva()
        {
            //encerrar = Boolean.TrueString,
            // intencao.Text == Re 
            
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            codItem.Text = $"{row.Cells[0].Value}";
            situacao.Text = $"{row.Cells[1].Value}";
            nomeItem.Text = $"{row.Cells[2].Value}";
            numExemplar.Text = $"{row.Cells[3].Value}";
            tipoItem.Text = $"{row.Cells[4].Value}";
            localizacao.Text = $"{row.Cells[5].Value}";
            codLeitor.Text = $"{row.Cells[6].Value}";
            nomeLeitor.Text = $"{row.Cells[7].Value}";
            dataReserva.Text = $"{row.Cells[8].Value}";
            prazoReserva.Text = $"{row.Cells[9].Value}";
            situacao.Text = $"{row.Cells[10].Value}";

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
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                MessageBox.Show("Livro indisponivel para reserva!");


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
    }
}

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

namespace Cadastro_Leitor
{
    public partial class CadLeitor : Form
    {
        public int indexRow { get; private set; }

        public CadLeitor()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codLeitor, nome, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero FROM MvtBibLeitor";
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

        private void saveLeitor_Click(object sender, EventArgs e)
        {
            var leitor = new Leitor()
            {

                nome = this.nome.Text,
                sexo = this.sexo.Text,
                dataNascimento = this.dataNascimento.Text,
                cpf = this.rg.Text,
                rg = this.rg.Text,
                email = this.email.Text,
                telefone = this.telefone.Text,                
                telefoneCelular = this.telefoneCelular.Text,
                enderecoNome = this.enderecoNome.Text,
                enderecoBairro = this.enderecoBairro.Text,
                enderecoCidade = this.enderecoCidade.Text,
                enderecoCEP = this.enderecoCEP.Text,
                enderecoUF = this.enderecoUF.Text,
                enderecoNumero = this.enderecoNumero.Text,
                codLeitor = string.IsNullOrEmpty(this.codLeitor.Text)
                ? 0
                : int.Parse(this.codLeitor.Text)

            };

            leitor.Salvar();


            MessageBox.Show("Cadastro feito com sucesso!");

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codLeitor, nome, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero FROM MvtBibLeitor";
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

        private void deleteLeitor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR o Leitor? ", "Cadastro do Leitor", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();



                    var sqlQuery = "DELETE MvtBibLeitor Where codLeitor = '" + codLeitor.Text + "'" + "SELECT codLeitor, nome, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero FROM MvtBibLeitor";
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
            this.dataGridView1.Columns[0]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[1]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[2]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[3]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[4]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[5]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[6]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[7]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[8]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[9]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[10]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[11]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[12]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[13]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[14]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[0].HeaderText = "Código";
            this.dataGridView1.Columns[1].HeaderText = "Nome";
            this.dataGridView1.Columns[2].HeaderText = "Sexo";
            this.dataGridView1.Columns[3].HeaderText = "Data de nascimento";
            this.dataGridView1.Columns[4].HeaderText = "CPF";
            this.dataGridView1.Columns[5].HeaderText = "RG";
            this.dataGridView1.Columns[6].HeaderText = "E-MAIL";
            this.dataGridView1.Columns[7].HeaderText = "Telefone";
            this.dataGridView1.Columns[8].HeaderText = "Telefone Celular";
            this.dataGridView1.Columns[9].HeaderText = "Nome da rua";
            this.dataGridView1.Columns[10].HeaderText = "Nome do bairro";
            this.dataGridView1.Columns[11].HeaderText = "Nome da cidade";
            this.dataGridView1.Columns[12].HeaderText = "CEP";
            this.dataGridView1.Columns[13].HeaderText = "UF";

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

            codLeitor.Text = $"{row.Cells[0].Value}";
            nome.Text = $"{row.Cells[1].Value}";
            sexo.Text = $"{row.Cells[2].Value}";
            dataNascimento.Text = $"{row.Cells[3].Value}";
            cpf.Text = $"{row.Cells[4].Value}";
            rg.Text = $"{row.Cells[5].Value}";
            email.Text = $"{row.Cells[6].Value}";
            telefone.Text = $"{row.Cells[7].Value}";
            telefoneCelular.Text = $"{row.Cells[8].Value}";
            enderecoNome.Text = $"{row.Cells[9].Value}";
            enderecoBairro.Text = $"{row.Cells[10].Value}";
            enderecoCidade.Text = $"{row.Cells[11].Value}";
            enderecoCEP.Text = $"{row.Cells[12].Value}";
            enderecoUF.Text = $"{row.Cells[13].Value}";
            enderecoNumero.Text = $"{row.Cells[14].Value}";

        }

        private void sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;                      
        }       

        private void cpf_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox; 
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 3 || i.Text.Length == 7)
                    i.Text += ".";               
                else if (i.Text.Length == 11)
                    i.Text += "-";
                i.SelectionStart = i.Text.Length + 1;
            }
        }

        private void rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 1 || i.Text.Length == 5)
                    i.Text += ".";               
                i.SelectionStart = i.Text.Length + 1;

            }
        }

        private void enderecoCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 5 || i.Text.Length == 9)
                    i.Text += "-";
                i.SelectionStart = i.Text.Length + 1;

            }
        }

        private void telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 0)
                    i.Text += "(";
                else if (i.Text.Length == 3)
                    i.Text += ") ";
                else if (i.Text.Length == 9)
                    i.Text += "-";

                i.SelectionStart = i.Text.Length + 1;

            }
        }

        private void telefoneCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 0)
                    i.Text += "(";
                else if (i.Text.Length == 3)
                    i.Text += ") ";
                else if (i.Text.Length == 10)
                    i.Text += "-";

                i.SelectionStart = i.Text.Length + 1;

            }
        }

        private void dataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 2 || i.Text.Length == 5)
                    i.Text += "/";              
                i.SelectionStart = i.Text.Length + 1;
            }
        }

        private void sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void enderecoCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void enderecoUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }
    }
}

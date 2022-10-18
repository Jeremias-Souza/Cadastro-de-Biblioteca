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
            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                MessageBox.Show("É necessario adicionar o nome do autor. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(sexo.Text))
            {
                MessageBox.Show("É necessario informar o sexo do Leitor. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(dataNascimento.Text))
            {
                MessageBox.Show("É necessario informar a data de nascimento do autor. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(enderecoNome.Text))
            {
                MessageBox.Show("É necessario informar a rua do autor. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(enderecoBairro.Text))
            {
                MessageBox.Show("É necessario informar o bairro do autor. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(enderecoCidade.Text))
            {
                MessageBox.Show("É necessario informar a cidade do autor. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(enderecoUF.Text))
            {
                MessageBox.Show("É necessario informar o estado do autor. ");
                return;
            }
            if (enderecoUF.Text != ("AC") && enderecoUF.Text != ("AL") && enderecoUF.Text != ("AP") && enderecoUF.Text != ("AM") && enderecoUF.Text != ("BA") && enderecoUF.Text != ("CE") && enderecoUF.Text != ("DF") && enderecoUF.Text != ("ES") && enderecoUF.Text != ("GO") && enderecoUF.Text != ("MA") && enderecoUF.Text != ("MT") && enderecoUF.Text != ("MS") && enderecoUF.Text != ("MG") && enderecoUF.Text != ("PA") && enderecoUF.Text != ("PB") && enderecoUF.Text != ("PR") && enderecoUF.Text != ("PE") && enderecoUF.Text != ("PI") && enderecoUF.Text != ("RJ") && enderecoUF.Text != ("RN") && enderecoUF.Text != ("RS") && enderecoUF.Text != ("RO") && enderecoUF.Text != ("RR") && enderecoUF.Text != ("SC") && enderecoUF.Text != ("SP") && enderecoUF.Text != ("SE") && enderecoUF.Text != ("TO"))
            {
                MessageBox.Show("UF inválida");
                return;
            }

            var leitor = new Leitor()
            {

                nome = this.nome.Text,
                sexo = this.sexo.Text,
                dataNascimento = this.dataNascimento.Text,
                cpf = this.cpf.Text,
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
            this.dataGridView1.Columns["codLeitor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["sexo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataNascimento"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["cpf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["rg"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["email"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefone"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["telefoneCelular"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["enderecoNome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoBairro"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoCidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoCEP"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["enderecoUF"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoNumero"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["codLeitor"].HeaderText = "Código";
            this.dataGridView1.Columns["nome"].HeaderText = "Nome";
            this.dataGridView1.Columns["sexo"].HeaderText = "Sexo";
            this.dataGridView1.Columns["dataNascimento"].HeaderText = "Data de nascimento";
            this.dataGridView1.Columns["cpf"].HeaderText = "CPF";
            this.dataGridView1.Columns["rg"].HeaderText = "RG";
            this.dataGridView1.Columns["email"].HeaderText = "E-MAIL";
            this.dataGridView1.Columns["telefone"].HeaderText = "Telefone";
            this.dataGridView1.Columns["telefoneCelular"].HeaderText = "Telefone Celular";
            this.dataGridView1.Columns["enderecoNome"].HeaderText = "Nome da rua";
            this.dataGridView1.Columns["enderecoBairro"].HeaderText = "Nome do bairro";
            this.dataGridView1.Columns["enderecoCidade"].HeaderText = "Nome da cidade";
            this.dataGridView1.Columns["enderecoCEP"].HeaderText = "CEP";
            this.dataGridView1.Columns["enderecoUF"].HeaderText = "UF";
            this.dataGridView1.Columns["enderecoNumero"].HeaderText = "enderecoNumero";            

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

        
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            codLeitor.Text = $"{row.Cells["codLeitor"].Value}";
            nome.Text = $"{row.Cells["nome"].Value}";
            sexo.Text = $"{row.Cells["sexo"].Value}";
            dataNascimento.Text = $"{row.Cells["dataNascimento"].Value}";
            cpf.Text = $"{row.Cells["cpf"].Value}";
            rg.Text = $"{row.Cells["rg"].Value}";
            email.Text = $"{row.Cells["email"].Value}";
            telefone.Text = $"{row.Cells["telefone"].Value}";
            telefoneCelular.Text = $"{row.Cells["telefoneCelular"].Value}";
            enderecoNome.Text = $"{row.Cells["enderecoNome"].Value}";
            enderecoBairro.Text = $"{row.Cells["enderecoBairro"].Value}";
            enderecoCidade.Text = $"{row.Cells["enderecoCidade"].Value}";
            enderecoCEP.Text = $"{row.Cells["enderecoCEP"].Value}";
            enderecoUF.Text = $"{row.Cells["enderecoUF"].Value}";
            enderecoNumero.Text = $"{row.Cells["enderecoNumero"].Value}";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                      
            

        }

        private void sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;                      
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

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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

        private void enderecoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }
      

        private void enderecoUF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            string strTexto;
            strTexto = e.KeyChar.ToString();
            strTexto = strTexto.ToUpper();
            e.KeyChar = Convert.ToChar(strTexto);

            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
            base.OnKeyPress(e);

            /*if (enderecoUF.Text.Length == 2 )
            {
                e.Handled = true;
            }*/

            
        }

    }
}

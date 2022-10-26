using Microsoft.VisualBasic;
using Reserva;
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

namespace Cadastro_Editora
{
    public partial class CadEditora : Form
    {
        public int indexRow { get; private set; }

        public CadEditora()
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

                    string sqlQuery = "SELECT CodEditora, Nome FROM MvtBibEditora";
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

        private void saveEditora_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeEditora.Text))
            {
                MessageBox.Show("Nome da editora é obrigatorio. ");
                return;
            }

            var editora = new Editora()
            {
                nome = this.nomeEditora.Text,
                codEditora = string.IsNullOrEmpty(this.codeEditora.Text)
                ? 0
                : int.Parse(this.codeEditora.Text)
            };

            editora.Salvar();
            SelectTable();
            MessageBox.Show("Cadastro feito com sucesso!");
        }

        private void deleteEditora_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR a Editora? ", "Cadastro Editora", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "DELETE MvtBibEditora Where codEditora = '" + codeEditora.Text + "'" + "SELECT codEditora, nome FROM MvtBibEditora";  
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
            //Cód editora
            this.dataGridView1.Columns["CodEditora"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            

            //Nome editora
            this.dataGridView1.Columns["Nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["CodEditora"].HeaderText = "Código";
            this.dataGridView1.Columns["Nome"].HeaderText = "Nome";

            
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

        private void nomeEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            codeEditora.Text = $"{row.Cells["CodEditora"].Value}";
            nomeEditora.Text = $"{row.Cells["Nome"].Value}";
        }
    }
}

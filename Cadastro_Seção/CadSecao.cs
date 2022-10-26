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

namespace Cadastro_Seção
{
    public partial class CadSecao : Form
    {
        public int indexRow { get; private set; }

        public CadSecao()
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

                    string sqlQuery = "SELECT CodSecao, descricaoSecao FROM MvtBibSecao";
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
            ClearTextBoxes();
        }

        private void saveSecao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descricaoSecao.Text))
            {
                MessageBox.Show("É necessario adicionar uma descrição para a Seção. ");
                return;
            }

            var secao = new Seção()
            {
                descricaoSecao = this.descricaoSecao.Text,
                codSecao = string.IsNullOrEmpty(this.codSecao.Text)
                ? 0
                : int.Parse(this.codSecao.Text)
            };
            secao.Salvar();
            SelectTable();
                    
            MessageBox.Show("Cadastro feito com sucesso!");
           
        }

        private void deleteSecao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR a Seção? ", "Cadastro Seção", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "DELETE MvtBibSecao Where codSecao = '" + codSecao.Text + "'" + "SELECT codSecao, descricaoSecao FROM MvtBibSecao";
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
            this.dataGridView1.Columns["codSecao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["descricaoSecao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codSecao"].HeaderText = "Código";
            this.dataGridView1.Columns["descricaoSecao"].HeaderText = "Descrição";
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

            codSecao.Text = $"{row.Cells["codSecao"].Value}";
            descricaoSecao.Text = $"{row.Cells["descricaoSecao"].Value}";
        }
    }
}

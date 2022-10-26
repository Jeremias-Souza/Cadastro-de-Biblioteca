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

namespace Cadastro_Local
{
    public partial class CadLocal : Form
    {
        public int indexRow { get; private set; }

        public CadLocal()
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

                    string sqlQuery = "SELECT CodLocal, descricaoLocal FROM MvtBibLocal";
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

        private void saveLocal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descricaoLocal.Text))
            {
                MessageBox.Show("É necessario adicionar uma descrição para o local. ");
                return;
            }

            var local = new Local()
            {
                descricaoLocal = this.descricaoLocal.Text,
                codLocal = string.IsNullOrEmpty(this.codLocal.Text)
                ? 0
                : int.Parse(this.codLocal.Text)
            };

            local.Salvar();
            SelectTable();
            
            MessageBox.Show("Cadastro feito com sucesso!");

        }

        private void deleteLocal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR o Local? ", "Cadastro Local", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "DELETE MvtBibLocal Where codLocal = '" + codLocal.Text + "'" + "SELECT codLocal, descricaoLocal FROM MvtBibLocal";
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

            this.dataGridView1.Columns["codLocal"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["descricaoLocal"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codLocal"].HeaderText = "Código";
            this.dataGridView1.Columns["descricaoLocal"].HeaderText = "Descrição";
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

            codLocal.Text = $"{row.Cells["codLocal"].Value}";
            descricaoLocal.Text = $"{row.Cells["descricaoLocal"].Value}";
        }

    }
}

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
        }

        private void saveSecao_Click(object sender, EventArgs e)
        {
            var secao = new Seção()
            {
                descricaoSecao = this.descricaoSecao.Text,
            };

            secao.Salvar();

            MessageBox.Show("Cadastro feito com sucesso!");

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codSecao, descricaoSecao FROM MvtBibSecao";
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
            //Cód secao
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Descricao da secao
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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

            codSecao.Text = $"{row.Cells[0].Value}";
            descricaoSecao.Text = $"{row.Cells[1].Value}";
        }
    }
}

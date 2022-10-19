using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tabelas
{
    public partial class Autor : Form
    {
        public Autor()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codAutor, nomeAutor, descricaoAutor FROM MvtBibAutor WHERE codItem = {int.Parse(this.txtPesquisaAutor.Text)}";
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


            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }
    }
}

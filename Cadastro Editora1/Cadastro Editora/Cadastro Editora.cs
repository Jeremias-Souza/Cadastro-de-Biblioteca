using Biblioteca_Estágio;
using Cadastro_Editora;
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
    public partial class Editora : Form
    {
        private CadEditora editora = new CadEditora();


        private void AddEditora_Click(object sender, EventArgs e)
        {
            editora.Código = int.Parse(CodEditora.Text);
            editora.Nome = NameEditora.Text;


            editora.Salvar(editora);

            MessageBox.Show("Cadastro feito com sucesso!"); //Aviso casa seja feito com exito
                                                            

            //toolStripStatusLabel1.Text = "Pronto";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT Código, Nome FROM Cadastro_Editora1";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                // toolStripStatusLabel1.Text = "Finalizado com sucesso";
                statusStrip1.Refresh();

            }
            catch (Exception ex)
            {
                // toolStripStatusLabel1.Text = "Falha!";
                statusStrip1.Refresh();
                MessageBox.Show("Falha! \n" + ex.Message);

            }
        }       
       
               

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            CodEditora.Text = row.Cells[0].Value.ToString();
            NameEditora.Text = row.Cells[1].Value.ToString();
        }
    }
}

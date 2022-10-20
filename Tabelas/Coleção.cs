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

namespace Tabelas
{
    public partial class Coleção : Form
    {
        public Coleção()
        {
            InitializeComponent();

            /*try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codAutor, nomeAutor FROM MvtBibAutor";
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
            }*/
        }

        private void txtPesquisaAutor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

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

namespace Reserva
{
    public partial class salvar : Form
    {
        public salvar()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
           /* var reserva = new Reserva()
            {
                descricaoLocal = this.descricaoLocal.Text,
                codLocal = string.IsNullOrEmpty(this.codLocal.Text)
                ? 0
                : int.Parse(this.codLocal.Text)
            };

            local.Salvar();

            MessageBox.Show("Cadastro feito com sucesso!");


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
                    ClearTextBoxes();
                }


            }




            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }*/
        }
    }
}

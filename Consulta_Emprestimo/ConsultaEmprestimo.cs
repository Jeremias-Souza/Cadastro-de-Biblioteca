using Cadastro_Local;
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

namespace Consulta_Emprestimo
{
    public partial class ConsultaEmprestimo : Form
    {
        public ConsultaEmprestimo()
        {
            InitializeComponent();

            
            
        }

        private void btnPesquisaLocal_Click(object sender, EventArgs e)
        {
            CodLocal tela = new CodLocal();
            tela.Show();
        }

        private void codLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT descricaoLocal FROM MvtbibLocal WHERE codLocal = {int.Parse(this.codLocal.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.codLocal.Text = dt.Rows[0].Field<string>("descricaoLocal");
                        }
                    }
                }

                
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Código do local inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}

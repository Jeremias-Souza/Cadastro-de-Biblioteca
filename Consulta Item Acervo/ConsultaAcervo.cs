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

namespace Consulta_Item_Acervo
{
    public partial class ConsultaAcervo : Form
    {
        public ConsultaAcervo()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    
                    //ClearTextBoxes();
                }
                //this.formatColumns();

            }




            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaAcervo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nome, numExemplar, tipoItem, localizacao FROM dbo.MvtBibItemAcervo WHERE codItem = {int.Parse(this.txtItem.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.txtNomeItem.Text = dt.Rows[0].Field<string>("nome");
                            //this.numExemplar.Text = dt.Rows[0].Field<int>("numExemplar").ToString();
                            this.comboTipoItem.Text = dt.Rows[0].Field<string>("tipoItem");
                            this.txtLocal.Text = dt.Rows[0].Field<string>("localizacao");
                        }
                    }
                }

                MessageBox.Show("Item Carregado com sucesso!");
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                    MessageBox.Show("Livro indisponivel para reserva!");


                MessageBox.Show("Item inexistente!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

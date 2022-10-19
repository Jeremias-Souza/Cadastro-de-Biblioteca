using Cadastro_Item_Acervo;
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

namespace Consulta_Acervo_Item
{
    public partial class ConsultaAcervo : Form
    {
        public int indexRow { get; private set; }

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
                

            }




            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
           
        }       

        private void txtItem_Leave(object sender, EventArgs e)
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

                            if(MessageBox.Show("Foram achados registros que correspondem o Código do Item.\r\n\r\nDeseja preenchelos automaticamente?", "Consulta ITens do Acervo", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }

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

        private void btnItem_Click(object sender, EventArgs e)
        {
            CadAcervo tela = new CadAcervo();
            tela.Show();
        }

        

        private void txtNomeItem_Leave(object sender, EventArgs e)
        {
         
        }

        private void btnPesquisaLocal_Click(object sender, EventArgs e)
        {
            CadAcervo tela = new CadAcervo();
            tela.Show();
        }

        private void txtLocal_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }


    }
}

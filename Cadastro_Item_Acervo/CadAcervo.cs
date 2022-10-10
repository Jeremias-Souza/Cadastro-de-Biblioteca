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

namespace Cadastro_Item_Acervo
{
    public partial class CadAcervo : Form
    {
        public int indexRow { get; private set; }

        public CadAcervo()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma FROM MvtBibItemAcervo";
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

        

        private void saveAcervo_Click(object sender, EventArgs e)
        {
            var acervo = new Acervo()
            {
                                                                                                           
                codLocal = this.codLocal.Text,
                numExemplar = this.numeroExemplar.Text,
                nome = this.nomeAcervo.Text,
                codAutor = this.codAutor.Text,
                nomeAutor = this.nomeAutor.Text,
                codEditora = this.codEditora.Text,
                nomeEditora = this.nomeEditora.Text,
               // tipoItem = this.tipoItem.Text,
                nomeLocal = this.nomeLocal.Text,
                volume = this.volume.Text,
                anoEdicao = this.anoEdicao.Text,
                localizacao = this.localizacao.Text, 
                secao = this.secao.Text,
                idioma = this.idioma.Text,
                
            };

            acervo.Salvar();


            MessageBox.Show("Cadastro feito com sucesso!");

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT CodItem, Nome FROM MvtBibItemAcervo";
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

        private void deleteAcervo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR o Item do Acervo? ", "Cadastro Item do Acervo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();



                    var sqlQuery = "DELETE MvtBibItemAcervo Where codItem = '" + codItem.Text + "'" + "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma";
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
            //Cód editora
            this.dataGridView1.Columns[0]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Nome editora
            this.dataGridView1.Columns[1]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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

            codItem.Text = $"{row.Cells[0].Value}";
            codLocal.Text = $"{row.Cells[1].Value}";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //itemAcervo = this.comboBox1,
            
            
        }

        private void nomeColecao_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

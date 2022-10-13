using Microsoft.VisualBasic;
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
        string[] items = new string[20];

        public CadAcervo()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoITem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma FROM MvtBibItemAcervo";
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
            if (string.IsNullOrWhiteSpace(codLocal.Text))
            {
                MessageBox.Show("Código do local é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(numeroExemplar.Text))
            {
                MessageBox.Show("Numero do exemplar é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(codAutor.Text))
            {
                MessageBox.Show("Código do autor é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(nomeAutor.Text))
            {
                MessageBox.Show("Nome do autor é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(codEditora.Text))
            {
                MessageBox.Show("Código da editora é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(nomeEditora.Text))
            {
                MessageBox.Show("Nome da editora é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Tipo de item é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(nomeLocal.Text))
            {
                MessageBox.Show("Nome do local é obrigatorio. ");
                return;
            }
            if (string.IsNullOrWhiteSpace(localizacao.Text))
            {
                MessageBox.Show("Código da prateleira é obrigatorio. ");
                return;
            }




            var acervo = new Acervo()
            {
                                                                                                           
                codLocal = this.codLocal.Text,
                nome = this.nomeAcervo.Text,
                nomeLocal = this.nomeLocal.Text,
                nomeAutor = this.nomeAutor.Text,
                codAutor = this.codAutor.Text,
                nomeEditora = this.nomeEditora.Text,
                codEditora = this.codEditora.Text,
                nomeColecao = this.nomeColecao.Text,
                tipoItem = this.comboBox1.Text,
                numExemplar = this.numeroExemplar.Text,
                volume = this.volume.Text,
                anoEdicao = this.anoEdicao.Text,
                localizacao = this.localizacao.Text,
                secao = this.secao.Text,
                idioma = this.idioma.Text,
                codItem = string.IsNullOrEmpty(this.codItem.Text)
                ? 0
                : int.Parse(this.codItem.Text)

            };

            acervo.Salvar();                       
            MessageBox.Show("Cadastro feito com sucesso!");
            

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma FROM MvtBibItemAcervo";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                        /*int i = -1;
                        for (i = -1; i <= 19; i++)
                        {
                            comboBox1.SelectedIndex = i;
                            items[i] = comboBox1.SelectedItem.ToString();
                        }
                        comboBox1.Items.Clear();*/

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



                    var sqlQuery = "DELETE MvtBibItemAcervo Where codItem = '" + codItem.Text + "'" + "SELECT codItem, codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma FROM MvtBibItemAcervo";
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
            
            this.dataGridView1.Columns[0]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            this.dataGridView1.Columns[1]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[2]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[3]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[4]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[5]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[6]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[7]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[8]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[9]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[10]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[11]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[12]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[13]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[14]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns[15]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            this.dataGridView1.Columns[0].HeaderText = "Código Acervo";
            this.dataGridView1.Columns[1].HeaderText = "Código Local";
            this.dataGridView1.Columns[2].HeaderText = "Numero do exemplar";
            this.dataGridView1.Columns[3].HeaderText = "Nome do Local";
            this.dataGridView1.Columns[4].HeaderText = "Código do Autor";
            this.dataGridView1.Columns[5].HeaderText = "Nome do Autor";
            this.dataGridView1.Columns[6].HeaderText = "Código da Editora";
            this.dataGridView1.Columns[7].HeaderText = "Nome da editora";
            this.dataGridView1.Columns[8].HeaderText = "Nome da coleção";
            this.dataGridView1.Columns[9].HeaderText = "Tipo do item";
            this.dataGridView1.Columns[10].HeaderText = "Nome do local";
            this.dataGridView1.Columns[11].HeaderText = "Volume";           
            this.dataGridView1.Columns[12].HeaderText = "Ano da edição";
            this.dataGridView1.Columns[13].HeaderText = "Código Prateleira";
            this.dataGridView1.Columns[14].HeaderText = "Seção";
            this.dataGridView1.Columns[15].HeaderText = "Idioma";
            

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
            numeroExemplar.Text = $"{row.Cells[2].Value}";
            nomeLocal.Text = $"{row.Cells[3].Value}";
            codAutor.Text = $"{row.Cells[4].Value}";
            nomeAutor.Text = $"{row.Cells[5].Value}";
            codEditora.Text = $"{row.Cells[6].Value}";
            nomeEditora.Text = $"{row.Cells[7].Value}";
            nomeColecao.Text = $"{row.Cells[8].Value}";
            comboBox1.Text = $"{row.Cells[9].Value}";
            nomeAcervo.Text = $"{row.Cells[10].Value}";
            volume.Text = $"{row.Cells[11].Value}";
            anoEdicao.Text = $"{row.Cells[12].Value}";
            localizacao.Text = $"{row.Cells[13].Value}";
            secao.Text = $"{row.Cells[14].Value}";
            idioma.Text = $"{row.Cells[15].Value}";

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;                                
        }

        private void nomeColecao_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nomeAcervo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void nomeColecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void idioma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void codAutor_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void codAutor_Leave(object sender, EventArgs e)
        {
           
                //var select = $"SELECT nomeAutor FROM AUTOR WHERE codAutor = {int.Parse(this.codAutor.Text)}";
               // this.nomeAutor.Text = select;
             try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT NomeAutor FROM dbo.MvtBibAutor WHERE codAutor = {int.Parse(this.codAutor.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            this.codAutor.Text = dt.Rows[0].Field<int>("nomeAutor").ToString();
                        }
                    }
                }

                MessageBox.Show("Autor Carregado com sucesso!");
                ClearTextBoxes();



            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {

                MessageBox.Show("Falha! \n" + ex.Message);

            }


            

        }

        private void codEditora_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nomeEditora FROM MvtBibAutor WHERE codEditora = {int.Parse(this.codEditora.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            this.codEditora.Text = dt.Rows[0].Field<int>("nomeEditora").ToString();
                        }
                    }
                }

                MessageBox.Show("Autor Carregado com sucesso!");
                ClearTextBoxes();



            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {

                MessageBox.Show("Falha! \n" + ex.Message);

            }
        }
    }
}

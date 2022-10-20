﻿using Cadastro_Item_Acervo;
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
using Tabelas;

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

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Local tela = new Local();
            tela.Show();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            Autor tela = new Autor();
            tela.Show();
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {

        }

        private void btnSecao_Click(object sender, EventArgs e)
        {
            Secao tela = new Secao();
            tela.Show();
        }       

        private void txtAutor_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nomeAutor FROM dbo.MvtBibAutor WHERE codAutor = {int.Parse(this.txtAutor.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelAutor.Text = dt.Rows[0].Field<string>("nomeAutor");
                        }
                    }
                }

                MessageBox.Show("Autor Carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Autor inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void txtSecao_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT descricaoSecao FROM dbo.MvtBibSecao WHERE codSecao = {int.Parse(this.txtSecao.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelSecao.Text = dt.Rows[0].Field<string>("descricaoSecao");
                        }
                    }
                }

                MessageBox.Show("Seção Carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seção inexistente!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

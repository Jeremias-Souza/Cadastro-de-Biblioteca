﻿using Microsoft.VisualBasic;
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
    
    public partial class CadEditora : Form
    {
        public int indexRow { get; private set; }

        public CadEditora()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT CodEditora, Nome FROM MvtBibEditora";
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

        

        private void saveEditora_Click(object sender, EventArgs e)
        {
            var editora = new Editora()
            {
                nome = this.nomeEditora.Text,
                //codEditora = int.Parse(this.codeEditora.Text)
            };

            editora.Salvar();
            

            MessageBox.Show("Cadastro feito com sucesso!");

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT CodEditora, Nome FROM MvtBibEditora";
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

        private void deleteEditora_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR a Editora? ", "Cadastro Editora", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();



                    var sqlQuery = "DELETE MvtBibEditora Where codEditora = '" + codeEditora.Text + "'" + "SELECT codEditora, nome FROM MvtBibEditora";  
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

        /*public static bool existeEditora(Editora editora)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                string sqlQuery = "Select nome FROM MvtBibEditoraa WHERE nome='" + editora.nome + "'";
                da = new SqlDataAdapter(sqlQuery, cn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }

            return res;
        }*/

        private void formatColumns()
        {
            //Cód editora
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Nome editora
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            codeEditora.Text = $"{row.Cells[0].Value}";
            nomeEditora.Text = $"{row.Cells[1].Value}";
            
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

        private void nomeEditora_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
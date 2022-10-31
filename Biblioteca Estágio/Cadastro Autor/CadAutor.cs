using DnsClient.Protocol;
using Microsoft.Win32;
using Newtonsoft.Json.Converters;
using RazorEngine.Compilation.ImpromptuInterface.InvokeExt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.IO;
using System.Windows.Controls.Primitives;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Controls;
using Control = System.Windows.Forms.Control;
using TextBox = System.Windows.Forms.TextBox;
using System.Globalization;
using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CharacterCasing = System.Windows.Forms.CharacterCasing;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Data.SqlTypes;
using AventStack.ExtentReports.Model;
using System.Collections.Immutable;
using System.Data.Common;
using Page = System.Windows.Controls.Page;
using NetTopologySuite.Algorithm;

namespace Biblioteca_Estágio
{

    public partial class CadastroAutor : Form
    {

        int indexRow;

        public CadastroAutor()
        {
            InitializeComponent();
            SelectTable();
        }

        private void SelectTable()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codAutor, nomeAutor, descricaoAutor FROM MvtBibAutor";
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
       
        private void AddAutor_Click(object sender, EventArgs e) //Botao para adicionar o autor 
        {
            if (string.IsNullOrWhiteSpace(NomeAutor.Text))
            {
                MessageBox.Show("Nome do autor é obrigatorio. ");
                return;
            }

            var autor = new Autor()
            {
                nomeAutor = this.NomeAutor.Text,              
                descricaoAutor = this.InfAutor.Text,
                codAutor = string.IsNullOrEmpty(this.CodAutor.Text)
                ? 0
                : int.Parse(this.CodAutor.Text)
              
            };           
            autor.Salvar();
            SelectTable();

            MessageBox.Show("Cadastro feito com sucesso!");
             
        }

        private void btnDelete_Click(object sender, EventArgs e) //Botão para deletar autor
        {
            if (MessageBox.Show("Deseja realmente DELETAR o autor? ", "Cadastro_autor", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "DELETE MvtBibAutor Where codAutor = '" + CodAutor.Text + "'" + "SELECT codAutor, nomeAutor, descricaoAutor FROM MvtBibAutor";  //Deleta o autor pelo código digitado na caixa de código
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                ClearTextBoxes();
                SelectTable();
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }                  
        }

        private void formatColumns()
        {

            this.dataGridView1.Columns["CodAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["descricaoAutor"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["CodAutor"].HeaderText = "Código";
            this.dataGridView1.Columns["nomeAutor"].HeaderText = "Nome";
            this.dataGridView1.Columns["descricaoAutor"].HeaderText = "Descrição";            
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

        private void NomeAutor_KeyPress(object sender, KeyPressEventArgs e) //Aceitar apenas letras na caixa de texto do NomeAutor
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }       
        }

        private void CodAutor_KeyPress(object sender, KeyPressEventArgs e) //Poder apenas numeros na tabela de texto CodAutor 
        {
                 
        }      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            CodAutor.Text = $"{row.Cells["codAutor"].Value}";
            NomeAutor.Text = $"{row.Cells["nomeAutor"].Value}";
            InfAutor.Text = $"{row.Cells["descricaoAutor"].Value}";
        }

        private void NomeAutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
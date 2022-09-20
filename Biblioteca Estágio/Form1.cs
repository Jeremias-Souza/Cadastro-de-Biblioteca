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

namespace Biblioteca_Estágio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-LMGKQ6A\TREINAMENTO;Initial Catalog=TREINAMENTO;User ID=Jeremias Souza;Password=MOVTECH2022";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
                throw;
            }

           /* if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nome = OpenFileDialog.FileName;

                bmp = new Bitmap(nome)
            }*/

        }

        private void CodAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfAutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

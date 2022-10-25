using Biblioteca_Estágio;
using Cadastro_Editora;
using Cadastro_Item_Acervo;
using Cadastro_Leitor;
using Cadastro_Local;
using Cadastro_Seção;
using cons_emprestimo;
using Consulta_Acervo_Item;
using Reserva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroAutor_Click(object sender, EventArgs e)
        {
            CadastroAutor tela = new CadastroAutor();
            tela.Show();
        }

        private void cadastroAcervo_Click(object sender, EventArgs e)
        {
            CadAcervo tela = new CadAcervo();
            tela.Show();
        }

        private void cadastroEditora_Click(object sender, EventArgs e)
        {
            CadEditora tela = new CadEditora();
            tela.Show();
        }

        private void cadastroLeitor_Click(object sender, EventArgs e)
        {
            CadLeitor tela = new CadLeitor();
            tela.Show();
        }

        private void cadastroLocal_Click(object sender, EventArgs e)
        {
            CadLocal tela = new CadLocal();
            tela.Show();
        }

        private void cadastroSecao_Click(object sender, EventArgs e)
        {
            CadSecao tela = new CadSecao();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadReserva tela = new CadReserva();
            tela.Show();
        }

        private void consultaEmprest_Click(object sender, EventArgs e)
        {
            Consulta_emprestimo tela = new Consulta_emprestimo();
            tela.Show();
        }

        private void consultaAcervo_Click(object sender, EventArgs e)
        {
            ConsultaAcervo tela = new ConsultaAcervo();
            tela.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

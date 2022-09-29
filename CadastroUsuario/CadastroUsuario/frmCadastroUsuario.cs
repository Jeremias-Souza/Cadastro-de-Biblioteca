using MvtCadastroUsuario.Models;
using MvtCadastroUsuario.Repository;
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

namespace CadastroUsuario
{
    public partial class frmCadastroUsuario : Form
    {

        private UsuarioModel UsuarioParaRemocao { get; set; }
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregaUsuarios();
        }

        private void CarregaUsuarios()
        {
            if (dtgDados.Rows.Count > 0)
            {
                dtgDados.Rows.Clear();
            }
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            HashSet<UsuarioModel> hashUsuarios = usuarioRepository.GetUsuarios();
            if (hashUsuarios.Count > 0)
            {
                foreach (UsuarioModel usuario in hashUsuarios)
                {
                    PopulaUsuariosGrid(usuario);
                }

                dtgDados.AutoResizeRows();
                dtgDados.AutoResizeColumns();
            }
        }

        private void PopulaUsuariosGrid(UsuarioModel usuario)
        {
            DataGridViewRow row = dtgDados.Rows[dtgDados.Rows.Add()];
            row.Cells[colUsuario.Index].Value = usuario.Usuario;
            row.Cells[colNome.Index].Value = usuario.Nome;
            row.Cells[colCidade.Index].Value = usuario.Cidade;
            row.Tag = usuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe o usuário antes de salvar", "Mov.Tech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe o nome antes de salvar", "Mov.Tech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            UsuarioModel usuario = new UsuarioModel(txtUsuario.Text, txtNome.Text, txtCidade.Text);
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            try
            {
                usuarioRepository.SaveUsuario(usuario);
                CarregaUsuarios();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao salvar usuário:\r\n\r\n{ex.Message}", "Mov.Tech", MessageBoxButtons.OK);
            }

        }

        private void dtgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)
            {
                return;
            }

            UsuarioModel usuario = (UsuarioModel)dtgDados.Rows[e.RowIndex].Tag;
            txtUsuario.Text = usuario.Usuario;
            txtNome.Text = usuario.Nome;
            txtCidade.Text = usuario.Cidade;
        }

        private void LimpaCampos()
        {
            txtUsuario.Clear();
            txtNome.Clear();
            txtCidade.Clear();
        }


        private void dtgDados_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (UsuarioParaRemocao == null)
            {
                return;
            }

            UsuarioRepository usuarioRepository = new UsuarioRepository();
            try
            {
                usuarioRepository.DeleteUsuario(UsuarioParaRemocao);
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao remover o usuário:\r\n\r\n{ex.Message}", "Mov.Tech", MessageBoxButtons.OK);
            }
                UsuarioParaRemocao = null;
            CarregaUsuarios();
        }

        private void dtgDados_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            UsuarioParaRemocao = (UsuarioModel)e.Row.Tag;
            if (MessageBox.Show($"Confirma a remoção do usuário: {UsuarioParaRemocao.Usuario}", "Mov.Tech", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                UsuarioParaRemocao = null;
                e.Cancel = true;
            }
        }
    }
}

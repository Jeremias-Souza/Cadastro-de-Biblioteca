using MvtCadastroUsuario.Models;
using MvtCadastroUsuario.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvtCadastroUsuario.Repository
{
    public class UsuarioRepository
    { 
        public UsuarioRepository()
        {
        }

        public void SaveUsuario(UsuarioModel usuario)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("INSERT INTO tUsuario(usuario,nome,cidade)");
            sql.AppendLine("VALUES(@usuario,@nome,@cidade)");
            using (SqlConnection connection = new CustomConnection().GetConnection())
            {
                connection.Open();
               SqlTransaction t =  connection.BeginTransaction();
                try
                    {
                DeleteUsuario(usuario.Usuario,connection,t);
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), connection))
                {
                        cmd.Transaction = t;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario.Usuario;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar, 100).Value = usuario.Nome;
                    cmd.Parameters.Add("@cidade", SqlDbType.VarChar, 80).Value = usuario.Cidade;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                    t.Commit();
                }
                catch 
                {
                    //t.Rollback();
                    //throw;
                }
                connection.Close();
            }
        }

        public void DeleteUsuario(UsuarioModel usuario)
        {
            using (SqlConnection connection = new CustomConnection().GetConnection())
            {
                connection.Open();
                DeleteUsuario(usuario.Usuario,connection,null);
                connection.Close();
            }
        }

        private void DeleteUsuario(string usuario,SqlConnection connection,SqlTransaction t)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("DELETE FROM tUsuario WHERE usuario=@usuario");
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), connection))
            {
                if (t != null)
                {
                        cmd.Transaction = t;
                }
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public HashSet<UsuarioModel> GetUsuarios()
        {
            HashSet<UsuarioModel> hashUsuarios = new HashSet<UsuarioModel>();

            using (SqlConnection connection = new CustomConnection().GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(GetQueryUsuario("").ToString(), connection))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        hashUsuarios.Add(new UsuarioModel(
                            dr["usuario"] + "",
                            dr["nome"] + "",
                            dr["cidade"] + ""
                            ));
                    }
                    }
                connection.Close();
                }
            }
            return hashUsuarios;
        }

        private StringBuilder GetQueryUsuario(string usuario)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT");
            sql.AppendLine("usu.usuario");
            sql.AppendLine(",usu.nome");
            sql.AppendLine(",usu.cidade");
            sql.AppendLine("FROM tUsuario usu");
            if (!string.IsNullOrEmpty(usuario))
            {
                sql.AppendLine("WHERE usu.usuario=@usuario");
            }
            return sql;
        }
    }
}

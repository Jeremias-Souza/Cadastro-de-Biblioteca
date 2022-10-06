using Biblioteca_Estágio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Editora
{
    public class CadEditora
    {
        public int Código { get; set; }
        public string Nome { get; set; }

        public void Salvar(CadEditora editora)
        {

            //byte[] foto = GetFoto(autor.CaminhoFoto);

            var sql = "INSERT INTO Cadastro_Editora (Código, Nome) VALUES (@Código, @Nome)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {


                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.AddWithValue("@Código", editora.Código);
                    cmd.Parameters.AddWithValue("@Nome", editora.Nome);
                    cmd.ExecuteNonQuery();


                }

            }
        }
    }
}

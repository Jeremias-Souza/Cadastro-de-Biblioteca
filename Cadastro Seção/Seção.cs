using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Seção
{
    public class Seção
    {
        public int codSecao { get; set; }
        public string descricaoSecao { get; set; }

        public void Salvar(Seção secao)
        {
            var sql = "INSERT INTO MvtBIBSeco (codSecao, descricaoSecao) VALUES (@Código da seção, @Descrição da seção)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {

                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.AddWithValue("@Código da seção", secao.codSecao);
                    cmd.Parameters.AddWithValue("@Descrição da seção", secao.descricaoSecao);

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }
    }
}

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

        public void Salvar()
        {
            if (this.codSecao == 0)
            {
                var sql = "INSERT INTO MvtBibSecao (descricaoSecao) VALUES (@descricaoSecao)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@descricaoSecao", this.descricaoSecao);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                } return;
            }

            else
            {
                var sql = "UPDATE MvtBibSecao SET descricaoSecao = @descricaoSecao WHERE codSecao = @codSecao";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@descricaoSecao", this.descricaoSecao);
                        cmd.Parameters.AddWithValue("@codSecao", this.codSecao);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

        }
    }
}

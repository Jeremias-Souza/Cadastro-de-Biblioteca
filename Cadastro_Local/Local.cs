using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Local
{
    public class Local
    {
        public int codLocal { get; set; }
        public string Descricao { get; set; }

        public void Salvar()
        {
            var sql = "INSERT INTO MvtBibLocal (descricaoLocal) VALUES (@descricaoLocal)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.AddWithValue("@descricaoLocal", this.Descricao);

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }


        }
    }
}

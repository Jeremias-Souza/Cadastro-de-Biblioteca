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
            if (this.codLocal == 0)
            {
                var sql = "INSERT INTO MvtBibLocal (Descricao) VALUES (@Descricao)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@Descricao", this.Descricao);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                } return;
            }
            else
            {
                var sql = "UPDATE MvtBibLocal SET Descricao = @Descricao WHERE codLocal = @codLocal";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@Descricao", this.Descricao);
                        cmd.Parameters.AddWithValue("@codLocal", this.codLocal);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

        }
    }
}

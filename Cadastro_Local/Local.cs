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
        public string descricaoLocal { get; set; }

        public void Salvar()
        {
            if (this.codLocal == 0)
            {
                var sql = "INSERT INTO MvtBibLocal (descricaoLocal) VALUES (@descricaoLocal)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@descricaoLocal", this.descricaoLocal);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                } return;
            }
            else
            {
                var sql = "UPDATE MvtBibLocal SET descricaoLocal = @descricaoLocal WHERE codLocal = @codLocal";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@descricaoLocal", this.descricaoLocal);
                        cmd.Parameters.AddWithValue("@codLocal", this.codLocal);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

        }
    }
}

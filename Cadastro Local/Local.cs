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

        public void Salvar(Local local)
        {
            var sql = "INSERT INTO MvtBIBLocal (codLocal, descricaoLocal) VALUES (@Código local, @Descrição Local)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {

                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.AddWithValue("@Código local ", local.codLocal);
                    cmd.Parameters.AddWithValue("@Nome Local", local.descricaoLocal);
                    
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }
    }
}

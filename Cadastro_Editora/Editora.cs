using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Editora
{
    public class Editora
    {
        public int codEditora { get; set; }
        public string nome { get; set; }

         public void Salvar ()
         {
             var sql = "INSERT INTO MvtBibEditora (nome) VALUES (@nome)";
             using (SqlConnection cn = new SqlConnection(Conn.Strcon))
             {
                 cn.Open();
                 using (var cmd = new SqlCommand(sql, cn))
                 {

                     cmd.Parameters.AddWithValue("@nome", this.nome);

                     cmd.ExecuteNonQuery();
                 }
                 cn.Close();
             }


         }

       
    }


}

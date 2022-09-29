using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvtCadastroUsuario.Utils
{
    public class CustomConnection
    {
        private static string _ConnectionString { get;  } = "Server=MVTALESSANDRO\\SQLEXPRESS;Database=CadastroUsuario; Uid=Norem;Pwd=sa123;MultipleActiveResultSets=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_ConnectionString);
        }
    }
}

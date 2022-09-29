using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvtCadastroUsuario.Utils
{
    public static class ConvertUtls
    {
        public static string SqlString(this string value)
        {
            return "'" + value.Replace("'", "") + "'";
        }
    }
}

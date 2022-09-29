using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Biblioteca_Estágio
{
    internal class Conn
    {
        private static string server = @"DESKTOP-LMGKQ6A\TREINAMENTO";
        private static string dataBase = "CADASTRO_AUTOR";        
        private static string user = "Jeremias Souza";
        private static string password = "MOVTECH2022";
        

        public static string Strcon
        {
            get {return $"Data Source= {server}; Integrated Security=False; Initial Catalog= {dataBase};User ID={user}; Password={password}";}
        }
     
    }
}

 

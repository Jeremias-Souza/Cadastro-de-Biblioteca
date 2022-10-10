using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Local
{
    internal class Conn
    {
        private static string server = @"DESKTOP-LMGKQ6A\TREINAMENTO"; //Local MovTech
        //private static string server = @"DESKTOP-JTN552H\SQLEXPRESS"; //Local casa
        private static string dataBase = "CADASTRO_LOCAL";
        private static string user = "Jeremias Souza"; //Login MovTech 
        private static string password = "MOVTECH2022";
        /* private static string user = "sa";  //Login Casa
         private static string password = "05092002";*/


        public static string Strcon
        {
            get { return $"Data Source= {server}; Integrated Security=False; Initial Catalog= {dataBase};User ID={user}; Password={password}"; }
        }
    }
}

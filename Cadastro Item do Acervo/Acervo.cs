using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Item_do_Acervo
{
    public class Acervo
    {
        public int codItem { get; set; }
        public string codLocal { get; set; }
        public string numExemplar { get; set; }
        public string Nome { get; set; }
        public string codAutor { get; set; }
        public string nomeAutor { get; set; }
        public string codEditora { get; set; }
        public string nomeEditora { get; set; }
        public string tipoItem { get; set; }
        public string nomeLocal { get; set; }
        public string Volume { get; set; }
        public string anoEdicao { get; set; }
        public string localizacao { get; set; }
        public string secao { get; set; }
        public string idioma { get; set; }
       
       

        public void Salvar(Acervo acervo)
        {
            var sql = "INSERT INTO MvtBibAcervo (codItem, codLocal, numExemplar, Nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma) VALUES (@Código Item, @Código Local, @Numero do exemplar, @Nome, @Código do autor, @Nome do autor, @Código da editora, @Nome editora, @Tipo item, @Nome local, @Volume, @Ano da edição, @Localização, @Seção, @Idioma)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {


                    cmd.Parameters.AddWithValue("@Código Item", acervo.codItem);
                    cmd.Parameters.AddWithValue("@Código Local", acervo.codLocal);
                    cmd.Parameters.AddWithValue("@Numero do exemplar", acervo.numExemplar);
                    cmd.Parameters.AddWithValue("@Nome", acervo.Nome);
                    cmd.Parameters.AddWithValue("@Código do autor", acervo.codAutor);
                    cmd.Parameters.AddWithValue("@Nome do autor", acervo.nomeAutor);
                    cmd.Parameters.AddWithValue("@Código da editora", acervo.codEditora);
                    cmd.Parameters.AddWithValue("@Nome editora", acervo.nomeEditora);
                    cmd.Parameters.AddWithValue("@Tipo Item", acervo.tipoItem);
                    cmd.Parameters.AddWithValue("@Nome Local", acervo.nomeLocal);
                    cmd.Parameters.AddWithValue("@Volume", acervo.Volume);
                    cmd.Parameters.AddWithValue("@Ano de edição", acervo.anoEdicao);
                    cmd.Parameters.AddWithValue("@Localização", acervo.localizacao);
                    cmd.Parameters.AddWithValue("@Seção", acervo.secao);
                    cmd.Parameters.AddWithValue("@Idioma", acervo.idioma);
                    



                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Item_Acervo
{
    public class Acervo
    {
        public int codItem { get; set; }
        public string codLocal { get; set; }
        public string numExemplar { get; set; }
        public string nome { get; set; }
        public string codAutor { get; set; }
        public string nomeAutor { get; set; }
        public string codEditora { get; set; }
        public string nomeEditora { get; set; }
        public string tipoItem { get; set; }
        public string nomeLocal { get; set; }
        public string volume { get; set; }
        public string anoEdicao { get; set; }
        public string localizacao { get; set; }
        public string secao { get; set; }
        public string idioma { get; set; }

        public void Salvar()
        {
            if (this.codItem == 0)
            {
                var sql = "INSERT INTO MvtBibItemAcervo (codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma) VALUES (@codLocal, @numExemplar, @nome, @codAutor, @nomeAutor, @codEditora, @nomeEditora, @tipoItem, @nomeLocal, @Volume, @anoEdicao, @localizacao, @secao, @idioma)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@codLocal", this.codLocal);
                        cmd.Parameters.AddWithValue("@numExemplar", this.numExemplar);
                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@codAutor", this.codAutor);
                        cmd.Parameters.AddWithValue("@nomeAutor", this.nomeAutor);
                        cmd.Parameters.AddWithValue("@codEditora", this.codEditora);
                        cmd.Parameters.AddWithValue("@nomeEditora", this.nomeEditora);
                        cmd.Parameters.AddWithValue("@tipoItem", this.tipoItem);
                        cmd.Parameters.AddWithValue("@nomeLocal", this.nomeLocal);
                        cmd.Parameters.AddWithValue("@volume", this.volume);
                        cmd.Parameters.AddWithValue("@anoEdicao", this.anoEdicao);
                        cmd.Parameters.AddWithValue("@localizacao", this.localizacao);
                        cmd.Parameters.AddWithValue("@secao", this.secao);
                        cmd.Parameters.AddWithValue("@idioma", this.idioma);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return;
            }

            else
            {
                var sql = "UPDATE MvtBibItemAcervo (codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma) VALUES (@codLocal, @numExemplar, @nome, @codAutor, @nomeAutor, @codEditora, @nomeEditora, @tipoItem, @nomeLocal, @Volume, @anoEdicao, @localizacao, @secao, @idioma)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@codLocal", this.codLocal);
                        cmd.Parameters.AddWithValue("@numExemplar", this.numExemplar);
                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@codAutor", this.codAutor);
                        cmd.Parameters.AddWithValue("@nomeAutor", this.nomeAutor);
                        cmd.Parameters.AddWithValue("@codEditora", this.codEditora);
                        cmd.Parameters.AddWithValue("@nomeEditora", this.nomeEditora);
                        cmd.Parameters.AddWithValue("@tipoItem", this.tipoItem);
                        cmd.Parameters.AddWithValue("@nomeLocal", this.nomeLocal);
                        cmd.Parameters.AddWithValue("@volume", this.volume);
                        cmd.Parameters.AddWithValue("@anoEdicao", this.anoEdicao);
                        cmd.Parameters.AddWithValue("@localizacao", this.localizacao);
                        cmd.Parameters.AddWithValue("@secao", this.secao);
                        cmd.Parameters.AddWithValue("@idioma", this.idioma);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
       
    }
}

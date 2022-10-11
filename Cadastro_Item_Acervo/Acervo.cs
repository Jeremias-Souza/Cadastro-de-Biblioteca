﻿using System;
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
        public string nomeColecao { get; set; }
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
                var sql = "INSERT INTO MvtBibItemAcervo (codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, nomeColecao, tipoItem, nomeLocal, Volume, anoEdicao, localizacao, secao, idioma) VALUES (@codLocal, @numExemplar, @nome, @codAutor, @nomeAutor, @codEditora, @nomeEditora, @nomeColecao, @tipoItem, @nomeLocal, @Volume, @anoEdicao, @localizacao, @secao, @idioma)";
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
                        cmd.Parameters.AddWithValue("@nomeColecao", this.nomeColecao);
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
                var sql = "UPDATE MvtBibItemAcervo SET codLocal = @codLocal, numExemplar = @numExemplar, nome = @nome, codAutor = @CodAutor, nomeAutor = @nomeAutor, codEditora = @codEditora, nomeEditora = @nomeEditora, nomeColecao = @nomeColecao, tipoItem = @tipoItem, nomeLocal = @nomeLocal, Volume = @Volume, anoEdicao = @anoEdicao, localizacao = @localizacao, secao = @secao, idioma = @idioma WHERE codItem = @codItem";
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
                        cmd.Parameters.AddWithValue("@nomeColecao", this.nomeColecao);
                        cmd.Parameters.AddWithValue("@tipoItem", this.tipoItem);
                        cmd.Parameters.AddWithValue("@nomeLocal", this.nomeLocal);
                        cmd.Parameters.AddWithValue("@volume", this.volume);
                        cmd.Parameters.AddWithValue("@anoEdicao", this.anoEdicao);
                        cmd.Parameters.AddWithValue("@localizacao", this.localizacao);
                        cmd.Parameters.AddWithValue("@secao", this.secao);
                        cmd.Parameters.AddWithValue("@idioma", this.idioma);
                        cmd.Parameters.AddWithValue("@codItem", this.tipoItem);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
       
    }
}

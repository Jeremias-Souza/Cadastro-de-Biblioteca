using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva
{
    public class Reservaa
    {
        public int codItem { get; set; }
        public string situacao { get; set; }
        public string nomeItem { get; set; }
        public string numExemplar { get; set; }
        public string tipoItem { get; set; }
        public string localizacao { get; set; }
        public string codLeitor { get; set; }
        public string nomeLeitor { get; set; }
        public string dataReserva { get; set; }
        public string prazoReserva { get; set; }
        public string encerrar { get; set; }

    public void Salvar()
        {
            if (this.codItem == 0)
            {
                var sql = "INSERT INTO MvtBibReserva (situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar) VALUES (@situacao, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor, @dataReserva, @prazoReserva, @encerrar)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@situacao", this.situacao);
                        cmd.Parameters.AddWithValue("@nomeItem", this.nomeItem);
                        cmd.Parameters.AddWithValue("@numExemplar", this.numExemplar);
                        cmd.Parameters.AddWithValue("@tipoItem", this.tipoItem);
                        cmd.Parameters.AddWithValue("@localizacao", this.localizacao);
                        cmd.Parameters.AddWithValue("@codLeitor", this.codLeitor);
                        cmd.Parameters.AddWithValue("@nomeLeitor", this.nomeLeitor);
                        cmd.Parameters.AddWithValue("@dataReserva", this.dataReserva);
                        cmd.Parameters.AddWithValue("@prazoReserva", this.prazoReserva);
                        cmd.Parameters.AddWithValue("@encerrar", this.encerrar);
                        cmd.Parameters.AddWithValue("@codItem", this.codItem);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return;
            }
            else
            {
                var sql = "UPDATE MvtBibReserva SET situacao = @situacao, nomeItem = @nomeItem, numExemplar = @numExemplar, tipoItem = @tipoItem, localizacao = @localizacao, codLeitor = @codLeitor, nomeLeitor = @nomeLeitor, dataReserva = @dataReserva, prazoReserva = @prazoReserva, encerrar = @encerrar  WHERE codItem = @codItem";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@situacao", this.situacao);
                        cmd.Parameters.AddWithValue("@nomeItem", this.nomeItem);
                        cmd.Parameters.AddWithValue("@numExemplar", this.numExemplar);
                        cmd.Parameters.AddWithValue("@tipoItem", this.tipoItem);
                        cmd.Parameters.AddWithValue("@localizacao", this.localizacao);
                        cmd.Parameters.AddWithValue("@codLeitor", this.codLeitor);
                        cmd.Parameters.AddWithValue("@nomeLeitor", this.nomeLeitor);
                        cmd.Parameters.AddWithValue("@dataReserva", this.dataReserva);
                        cmd.Parameters.AddWithValue("@prazoReserva", this.prazoReserva);
                        cmd.Parameters.AddWithValue("@encerrar", this.encerrar);
                        cmd.Parameters.AddWithValue("@codItem", this.codItem);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva
{
    public class Reservaa
    {
        public string codItem { get; set; }
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
        public int numReserva { get; set; }


        public static bool existeReserva(Reservaa reserva)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                string sqlQuery = "SELECT codItem FROM MvtBibReserva WHERE codItem='" + reserva.codItem + "'";
                da = new SqlDataAdapter(sqlQuery, cn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }

            return res;
        }

        public void Salvar(Reservaa reserva)
        {
            if (existeReserva(reserva))
            {
                MessageBox.Show("Esse item não se encontra disponivel para reserva.", "Cadastro Item do Acervo");                
            }

            else
            {
                var sql = "INSERT INTO MvtBibReserva (codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar) VALUES (@codItem, @situacao, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor, @dataReserva, @prazoReserva, @encerrar)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@codItem", this.codItem);
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
                        cmd.ExecuteNonQuery();

                    }
                    cn.Close();
                }
            }                                   
        }
    }
}

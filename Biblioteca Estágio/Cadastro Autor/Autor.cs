using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Estágio
{
    public class Autor
    {
        public int codAutor { get; set; }
        public string nomeAutor { get; set; }
        public string descricaoAutor { get; set; }
        
      

        public void Salvar()
        {

            if (this.codAutor == 0)
            {
                var sql = "INSERT INTO MvtBibAutor (nomeAutor, descricaoAutor) VALUES (@nomeAutor, @descricaoAutor)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nomeAutor", this.nomeAutor);                     
                        cmd.Parameters.AddWithValue("@descricaoAutor", this.descricaoAutor);                       

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return;
            }

            else
            {
                var sql = "UPDATE MvtBibAutor SET nomeAutor = @nomeAutor, descricaoAutor = @descricaoAutor WHERE codAutor = @codAutor";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        
                        cmd.Parameters.AddWithValue("@nomeAutor", this.nomeAutor);
                        cmd.Parameters.AddWithValue("@descricaoAutor", this.descricaoAutor);                        
                        cmd.Parameters.AddWithValue("@codAutor", this.codAutor);
                        
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }





        }
                 
        /*private byte[] GetFoto(string caminhoFoto)
        {
                      
                byte[] foto;
                using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
                {

                    using (var reader = new BinaryReader(stream))
                    {
                        foto = reader.ReadBytes((int)stream.Length);
                    }
                }


                return foto;
            
        }*/
    } 
}

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
        public string Nome { get; set; }
        public string descricao { get; set; }

        public static bool existeautor(Autor autor)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                string sqlQuery = "SELECT codAutor FROM MvtBibAutor WHERE codAutor='" + autor.codAutor + "'";
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


        public void Salvar(Autor autor)
        {           

            var sql = "INSERT INTO MvtBibAutor (Nome, descricao) VALUES (@Nome, @descricao)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {

                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                    cmd.Parameters.AddWithValue("@descricao", autor.descricao);
                    
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }

        }

        


        /*else
        {
            var sql = "UPDATE MvtBibAutor SET Nome = @Nome, Descrição = @Descrição WHERE Código=" + autor.Código;
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {


                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                    cmd.Parameters.AddWithValue("@Descrição", autor.Descrição);
                    //cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                    //autor.CaminhoFoto = caminhoFoto;


                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }

        }

        try
        {
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();

                string sqlQuery = "SELECT Código, Nome, Descrição FROM MvtBibAutor";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        //dataGridView1.DataSource = dt;
                    }
                }
            }
           // toolStripStatusLabel1.Text = "Finalizado com sucesso";
           // statusStrip1.Refresh();

        }
        catch (Exception ex)
        {
           // toolStripStatusLabel1.Text = "Falha!";
           // statusStrip1.Refresh();
            MessageBox.Show("Falha! \n" + ex.Message);

        }

     }*/



        /*public static bool EditAutor(Autor autor)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                string sqlQuery = "Select Código FROM MvtBibAutor WHERE Código='" + autor.Código + "'";
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
        }*/





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

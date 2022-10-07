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
        public int Código { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string CaminhoFoto { get; set; }
        public byte[] Foto { get; set; }
        public object dataGridView1 { get; private set; }

        public void Salvar(Autor autor)
        {
             

            //byte[] foto = GetFoto(autor.CaminhoFoto);

            if (autor.Código != autor.Código)
            {
                var sql = "INSERT INTO CADASTRO (Código, Nome, Descrição) VALUES (@Código, @Nome, @Descrição)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        

                        cmd.Parameters.AddWithValue("@Código", autor.Código);
                        cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                        cmd.Parameters.AddWithValue("@Descrição", autor.Descrição);
                        //cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                        cmd.ExecuteNonQuery();                      
                    }
                    cn.Close();
                }
            }

            else
            {
                var sql = "UPDATE CADASTRO SET Nome = @Nome, Descrição = @Descrição WHERE Código=" + autor.Código;
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

                    string sqlQuery = "CADASTRO Código, Nome, Descrição FROM CADASTRO";
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

        }



        public static bool EditAutor(Autor autor)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                string sqlQuery = "Select Código FROM Cadastro_autor WHERE Código='" + autor.Código + "'";
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

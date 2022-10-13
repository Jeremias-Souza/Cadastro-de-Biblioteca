using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Leitor
{
    public class Leitor
    {
        public int codLeitor { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string dataNascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string telefoneCelular { get; set; }
        public string enderecoNome { get; set; }
        public string enderecoBairro { get; set; }
        public string enderecoCidade { get; set; }
        public string enderecoCEP { get; set; }
        public string enderecoUF { get; set; }
        public string enderecoNumero { get; set; }

        public void Salvar()
        {
            if (this.codLeitor == 0)
            {
                var sql = "INSERT INTO MvtBibLeitor (nome, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero) VALUES (@nome, @sexo, @dataNascimento, @cpf, @rg, @email, @telefone, @telefoneCelular, @enderecoNome, @enderecoBairro, @enderecoCidade, @enderecoCEP, @enderecoUF, @enderecoNumero)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@sexo", this.sexo);
                        cmd.Parameters.AddWithValue("@dataNascimento", this.dataNascimento);
                        cmd.Parameters.AddWithValue("@cpf", this.cpf);
                        cmd.Parameters.AddWithValue("@rg", this.rg);
                        cmd.Parameters.AddWithValue("@email", this.email);
                        cmd.Parameters.AddWithValue("@telefone", this.telefone);
                        cmd.Parameters.AddWithValue("@telefoneCelular", this.telefoneCelular);
                        cmd.Parameters.AddWithValue("@enderecoNome", this.enderecoNome);
                        cmd.Parameters.AddWithValue("@enderecoBairro", this.enderecoBairro);
                        cmd.Parameters.AddWithValue("@enderecoCidade", this.enderecoCidade);
                        cmd.Parameters.AddWithValue("@enderecoCEP", this.enderecoCEP);
                        cmd.Parameters.AddWithValue("@enderecoUF", this.enderecoUF);
                        cmd.Parameters.AddWithValue("@enderecoNumero", this.enderecoNumero);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return;
            } 

            else
            {
               
                var sql = "UPDATE MvtBibLeitor SET nome = @nome, sexo = @sexo, dataNascimento = @dataNascimento, cpf = @cpf, rg = @rg, email = @email, telefone = @telefone, telefoneCelular = @telefoneCelular, enderecoNome = @enderecoNome, enderecoBairro = @enderecoBairro, enderecoCidade = @enderecoCidade, enderecoCEP = @enderecoCEP, enderecoUF = @enderecoUF, enderecoNumero = @enderecoNumero WHERE codLeitor = @codLeitor";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@sexo", this.sexo);
                        cmd.Parameters.AddWithValue("@dataNascimento", this.dataNascimento);
                        cmd.Parameters.AddWithValue("@cpf", this.cpf);
                        cmd.Parameters.AddWithValue("@rg", this.rg);
                        cmd.Parameters.AddWithValue("@email", this.email);
                        cmd.Parameters.AddWithValue("@telefone", this.telefone);
                        cmd.Parameters.AddWithValue("@telefoneCelular", this.telefoneCelular);
                        cmd.Parameters.AddWithValue("@enderecoNome", this.enderecoNome);
                        cmd.Parameters.AddWithValue("@enderecoBairro", this.enderecoBairro);
                        cmd.Parameters.AddWithValue("@enderecoCidade", this.enderecoCidade);
                        cmd.Parameters.AddWithValue("@enderecoCEP", this.enderecoCEP);
                        cmd.Parameters.AddWithValue("@enderecoUF", this.enderecoUF);
                        cmd.Parameters.AddWithValue("@enderecoNumero", this.enderecoNumero);
                        cmd.Parameters.AddWithValue("@codLeitor", this.codLeitor);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

        }
    }
}

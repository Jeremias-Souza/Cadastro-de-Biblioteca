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
        public string leitor { get; set; }
        public string Sexo { get; set; }
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

        public void Salvar(Leitor leitor)
        {
            var sql = "INSERT INTO MvtBIBLeitor (codLeitor, Leitor, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero) VALUES (@Código Leitor, @Leitor, @Sexo, @Data de nascimento, @CPF, @RG, @E-MAIL, @Telefone, @Telefone Celular, @Endereco Nome, @Endereco Bairro, @Endereco Cidade, @Endereco CEP, @Endereco UF, @Endereco Numero)";
            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();
                using (var cmd = new SqlCommand(sql, cn))
                {


                    cmd.Parameters.AddWithValue("@Código Leitor", leitor.codLeitor);
                    cmd.Parameters.AddWithValue("@Leitor", leitor.leitor);
                    cmd.Parameters.AddWithValue("@Sexo", leitor.Sexo);
                    cmd.Parameters.AddWithValue("@Data de Nascimento", leitor.dataNascimento);
                    cmd.Parameters.AddWithValue("@CPF", leitor.cpf);
                    cmd.Parameters.AddWithValue("@RG", leitor.rg);
                    cmd.Parameters.AddWithValue("@E-MAIL", leitor.email);
                    cmd.Parameters.AddWithValue("@Telefone", leitor.telefone);
                    cmd.Parameters.AddWithValue("@Telefone Celular", leitor.telefoneCelular);
                    cmd.Parameters.AddWithValue("@Endereco Nome", leitor.enderecoNome);
                    cmd.Parameters.AddWithValue("@Endereco Bairro", leitor.enderecoBairro);
                    cmd.Parameters.AddWithValue("@Endereco Cidade", leitor.enderecoCidade);
                    cmd.Parameters.AddWithValue("@Endereco CEP", leitor.enderecoCEP);
                    cmd.Parameters.AddWithValue("@Endereco UF", leitor.enderecoUF);
                    cmd.Parameters.AddWithValue("@Endereco Numero", leitor.enderecoNumero);




                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }
    }
}

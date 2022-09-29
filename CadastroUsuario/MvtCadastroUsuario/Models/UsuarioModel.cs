using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvtCadastroUsuario.Models
{
    public class UsuarioModel
    {
        public string Usuario { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public UsuarioModel(string usuario, string nome, string cidade)
        {
            Usuario = usuario;
            Nome = nome;
            Cidade = cidade;
        }
    }
}

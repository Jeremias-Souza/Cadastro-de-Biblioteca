using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Estágio
{
    public class FotosAutor
    {
        
        public int CaminhoFoto { get; set; }
        public byte[] Foto { get; set; }

        public void Salvar(CadastroAutor cadastro)
        {
            byte[] foto = GetFoto(cadastro.CaminhoFoto)
        }

        private byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                foto = reader.ReadBytes(stream.Length);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Program
    {
        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public List<Documento> Documentos { get; set; }
            public List<Endereco> Enderecos { get; set; }
        }

        public class Documento
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
            public string Numero { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
        }

        public class Endereco
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Cep { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
        }
    }
}

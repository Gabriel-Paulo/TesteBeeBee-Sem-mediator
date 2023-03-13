using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Web.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Column("id")]
        [Display(Name = "id")]
        public int Id { get; set; }
        [Column("nome")]
        [Display(Name = "nome")]
        public string Nome { get; set; }
        [Column("email")]
        [Display(Name = "email")]
        public string Email { get; set; }
        [Column("telefone")]
        [Display(Name = "telefone")]
        public string Telefone { get; set; }
        [Column("datanascimento")]
        [Display(Name = "datanascimento")]
        public string DataNascimento { get; set; }
        public List<Documento> Documentos { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}
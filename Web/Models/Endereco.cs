using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace Web.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Column("logradouro")]
        [Display(Name = "logradouro")]
        public string Logradouro { get; set; }
        [Column("numero")]
        [Display(Name = "numero")]
        public string Numero { get; set; }
        [Column("complemento")]
        [Display(Name = "complemento")]
        public string Complemento { get; set; }
        [Column("bairro")]
        [Display(Name = "bairro")]
        public string Bairro { get; set; }
        [Column("cidade")]
        [Display(Name = "cidade")]
        public string Cidade { get; set; }
        [Column("estado")]
        [Display(Name = "estado")]
        public string Estado { get; set; }
        [Column("cep")]
        [Display(Name = "cep")]
        public string Cep { get; set; }
        public int ClienteId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Web.Models
{
    [Table("documentos")]
    public class Documento
    {
        [Column("id")]
        [Display(Name = "id")]

        public int Id { get; set; }
        [Column("tipodocumento")]
        [Display(Name = "tipo de documento")]
        public string Tipo { get; set; }
        [Column("numerodocumento")]
        [Display(Name = "numero do documento")]
        public string Numero { get; set; }
        public int ClienteId { get; set; }
    }
}

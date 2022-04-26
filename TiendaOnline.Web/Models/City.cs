using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TiendaOnline.Web.Models
{
    public class City
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Name { get; set; }
        [JsonIgnore] //lo ignora en la respuesta json
        [NotMapped] //no se crea en la base de datos
        public int IdDepartment { get; set; }
    }
}

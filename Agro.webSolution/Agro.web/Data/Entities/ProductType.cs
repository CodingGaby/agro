using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class ProductType
    {
        //Creado por JGGO
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} NO puede tener mas de {1} caracteres")]
        [Display(Name = "Tipo de producto")]
        public string? Name { get; set; } //Nombre del Tipo de producto
        
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo {0} NO puede tener mas de {1} caracteres")]
        [Display(Name = "Descripción de producto")]
        public string? Description { get; set; } //Descripción del Tipo de producto
    }
}
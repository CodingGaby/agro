using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class City
    {
        //Creado por JGGO
        public int Id { get; set; }

        //Data anotations de el atributo Name
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Mostrar el error en la vista
        [Display(Name = "Ciudad")] //Cambiar el nombre al campo Name
        [MaxLength(100,ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")] //Se establece que Name no puede tener mas de 100 caracteres
        public string Name { get; set; } = null!;
    }
}

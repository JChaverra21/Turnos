using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        //Definir propiedades
        public int IdEspecialidad { get; set; } //primary key de la tabla

        public string Descripcion { get; set; }
    }
}
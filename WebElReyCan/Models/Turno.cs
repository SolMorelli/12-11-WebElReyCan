using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string Fecha { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string Hora { get; set; }

        [DisplayName("Nombre Mascota")]
        [Required(ErrorMessage = "Campo requerido.")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string NombreMascota { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string Raza { get; set; }

        [Column(TypeName = "int")]
        public int Edad { get; set; }

        [DisplayName("Nombre Dueño")]
        [Required(ErrorMessage = "Campo requerido.")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string NombreDuenio { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string Celular { get; set; }
    }
}
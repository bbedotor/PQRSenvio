using System;
using System.ComponentModel.DataAnnotations;

namespace PQRSenvio.Web.Data.Entities
{
    public class Category
    {

        public int Id { get; set; }


        [Required]
        [MaxLength(255)]
        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Display(Name = "Activo")]
        public bool Is_Active { get; set; }

        [MaxLength(500)]
        [Display(Name ="Descripción")]
        public string description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Fecha de Creación")]
        public DateTime created_at { get; set; }

        [Display(Name = "Creado por")]
        public string created_by_id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Fecha de Modificación")]
        public DateTime modified_at { get; set; }

        [Display(Name ="modificado por")]
        public string modified_by_id { get; set; }

        public bool deleted { get; set; }



    }
}

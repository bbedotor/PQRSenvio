using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PQRSenvio.Web.Data.Entities
{
    public class Case
    {
        [Required]
        public int  Id { get; set; }


        [MaxLength(255)]
        [Display(Name = "Nombre")]
        public string name { get; set; }

        [MaxLength(500)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name ="Categoria")]
        public string category_id { get; set; }

        [Display(Name = "Tema")]
        public string theme_id { get; set; }

        [Display(Name ="Detalle")]
        public string detail_id { get; set; }

        [Required]
        [Display(Name = "Asignado a")]
        public string assigned_user_id { get; set; }

        [Display(Name = "ANS")]
        public int ans { get; set; }

        [Display(Name = "Cuenta")]
        public string account_id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Creación")]
        public DateTime created_at { get; set; }

        [Display(Name = "creado por")]
        public string created_by_id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Modificación")]
        public DateTime modified_at { get; set; }


        [Display(Name = "Modificado por")]
        public string modified_by_id { get; set; }

        public bool deleted { get; set; }



    }
}

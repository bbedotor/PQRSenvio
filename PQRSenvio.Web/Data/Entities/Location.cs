using PQRSenvio.Web.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace PQRSenvio.Web.Data
{
    public class Location
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Display(Name = "Activo")]
        public bool is_active { get; set; }

        [MaxLength(500)]
        [Display(Name = "Description")]
        public string description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Creación")]
        public DateTime Created_at { get; set; }

        [Display(Name = "Creado por")]
        public string created_by_id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Modificación")]
        public DateTime modified_at { get; set; }

        [Display(Name = "Modificado por")]
        public string modified_by_id { get; set; }

        public bool deleted { get; set; }

        
        public State State { get; set; }

        public Country Country { get; set; }

        public City City { get; set; }



    }
}

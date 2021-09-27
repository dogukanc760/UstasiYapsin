using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Ilceler : IEntity
    {
        [Required]
        [Key]
        public int IlceId { get; set; }
        [Required]
        public int IlId { get; set; }
        [Required]
        public string Ilce { get; set; }
        [Required]
        public virtual Iller Il { get; set; }
    }
}

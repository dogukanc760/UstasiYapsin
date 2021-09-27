using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Sector : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int CategoryId { get; set; }
        [Required]
        [MinLength(5), MaxLength(250)]
        public string SectorName { get; set; }
    }
}

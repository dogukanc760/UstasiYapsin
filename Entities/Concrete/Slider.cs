using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Slider : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(5), MaxLength(350)]
        public string SliderUrl { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int SliderSira { get; set; }
    }
}

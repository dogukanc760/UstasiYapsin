using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class MobileImage : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        public string ImageUrl { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int ImageSira { get; set; }
    }
}

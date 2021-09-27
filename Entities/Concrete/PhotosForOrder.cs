using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class PhotosForOrder : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderFromId { get; set; }
        [Required]
        [MinLength(10), MaxLength(450)]
        public string PhotoUrl { get; set; }
        [Required]
        [MinLength(5), MaxLength(150)]
        public string PhotoSubTitle { get; set; }
        [Required]
        [MinLength(5), MaxLength(150)]
        public string PhotoTitle { get; set; }
        public string CreatedAt { get; set; }
    }
}

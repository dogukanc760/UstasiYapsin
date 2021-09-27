using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Referance : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int UserId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderId { get; set; }
        [Required]
        [MinLength(0), MaxLength(250)]
        public string ReferanceContent { get; set; }
        [Required]
        [MinLength(0), MaxLength(250)]
        public string ReferanceImage { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

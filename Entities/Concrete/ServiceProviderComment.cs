using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class ServiceProviderComment : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int ServiceProviderId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int UserId { get; set; }
        [Required]
        [MinLength(5), MaxLength(150)]
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

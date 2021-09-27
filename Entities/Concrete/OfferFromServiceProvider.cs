using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class OfferFromServiceProvider : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderFromCustomerId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int ServiceProviderId { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal OfferPrice { get; set; }
        [Required]
        [MinLength(10)]
        public string OfferDescription { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

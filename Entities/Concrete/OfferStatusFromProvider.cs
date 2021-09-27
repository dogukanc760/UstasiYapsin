using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class OfferStatusFromProvider : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OfferId { get; set; }
        [Required]
        [Range(0, 15)]
        public int Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

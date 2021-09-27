using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class OfferFromCustomer : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int OrderFromCustomerId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}

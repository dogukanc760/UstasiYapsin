using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class OrderFromCustomerStatus : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int? OrderFromId { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal? OrderPrice { get; set; }
        [Required]
        [MinLength(10),MaxLength(450)]
        public string OrderDescription { get; set; }
        [Required]
        public bool? IsComplete { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

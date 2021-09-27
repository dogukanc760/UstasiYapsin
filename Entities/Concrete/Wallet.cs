using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Wallet : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int UserId { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal WalletPrice { get; set; }
        [Required]
        [MinLength(5), MaxLength(150)]
        public string OperationDescription { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class BusinessUser : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [MinLength(8)]
        [MaxLength(50)]
        [Required]
        public string Rank { get; set; }
        [MinLength(8)]
        [MaxLength(150)]
        public string TaxNum { get; set; }
        [MinLength(8)]
        [MaxLength(150)]
        public string TaxPlace { get; set; }
        [MinLength(8)]
        [MaxLength(150)]
        public string ServiceSector { get; set; }
        [MinLength(8)]
        [MaxLength(150)]
        public string ServiceCategory { get; set; }
        [MinLength(5)]
        [MaxLength(150)]
        public string ServiceCities { get; set; }
        [MinLength(5)]
        [MaxLength(150)]
        public string ServiceDistinct { get; set; }
        [MinLength(4)]
        [MaxLength(250)]
        public string ServiceDays { get; set; }
        [MinLength(8)]
        [MaxLength(250)]
        public string ServiceHours { get; set; }
        [Required]
        public bool IsActiveNow { get; set; }
        [Required]
        public bool IsAllTime { get; set; }
        [MinLength(8)]
        [MaxLength(350)]
        public string AboutUs { get; set; }
        [Required]
        public bool IsTrue { get; set; }
        [Required]
        public bool UserCallMe { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

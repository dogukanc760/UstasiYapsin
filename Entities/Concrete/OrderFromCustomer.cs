using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class OrderFromCustomer : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderCreatorId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int ServiceUserId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int CategoryId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int SubCategoryId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int CityId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int DistinctId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int QuestionId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int PhotoRefId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Required]
        public bool? IsHurry { get; set; }
        [Required]
        public DateTime? IsWhen { get; set; }
        [Required]
        public int? IsCompleted { get; set; }
        [Required]
        public bool? IsTrue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [Required]
        public bool? ComeMyAdress { get; set; }
        [Required]
        [MinLength(10),MaxLength(550)]
        public string AdressLocate { get; set; }
    }
}

using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Category : IEntity
    {
        [Required]
        public int Id { get; set; }
        [MinLength(5)]
        [MaxLength(100)]
        public string CategoryName { get; set; }
    }
}

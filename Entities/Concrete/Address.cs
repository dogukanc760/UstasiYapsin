using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public class Address : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [MinLength(15)]
        [Required]
        public string Adress { get; set; }
    }
}

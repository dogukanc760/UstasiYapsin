using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class FavoriteProvider : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ServiceProviderId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public bool IsFavorite { get; set; }
    }
}

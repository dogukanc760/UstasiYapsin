using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class FrequentlyQuestionAnswer : IEntity
    {
        [Required]
        public int Id { get; set; }
        [MinLength(5)]
        [MaxLength(150)]
        public string FrequentlyQuestion { get; set; }
        [MinLength(5)]
        [MaxLength(150)]
        public string FrequentlyAnswer { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}

using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class QuestionMain : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int SubCategoryId { get; set; }
        [Required]
        [MinLength(350)]
        public string Name { get; set; }
    }
}

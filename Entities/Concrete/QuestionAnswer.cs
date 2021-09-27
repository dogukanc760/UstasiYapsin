using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class QuestionAnswer : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int QuestionMainId { get; set; }
        [Required]
        [MinLength(10), MaxLength(350)]
        public string Question { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

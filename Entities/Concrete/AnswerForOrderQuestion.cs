using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public class AnswerForOrderQuestion : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int QuestionAnswerId { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(350)]
        public string AnswerContent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

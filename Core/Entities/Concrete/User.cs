using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(5), MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5), MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        [MinLength(5), MaxLength(75)]
        public string Email { get; set; }
        [Required]
        [MinLength(8), MaxLength(25)]
        public string Gsm { get; set; }
        [Required]
        public bool? Status { get; set; }
        [Required]
        public int? Type { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Description { get; set; }
        public bool? IsBanned { get; set; }


    }
}

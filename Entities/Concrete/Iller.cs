using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Iller : IEntity
    {
        public Iller()
        {
            Ilcelers = new HashSet<Ilceler>();
        }

        [Key]
        public int IlId { get; set; }
        public string Il { get; set; }

        public virtual ICollection<Ilceler> Ilcelers { get; set; }
    }
}

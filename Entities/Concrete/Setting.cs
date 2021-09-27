using Core.Entities;

using System;
using System.Collections.Generic;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public  class Setting : IEntity
    {
        public int Id { get; set; }
        public string Mail1 { get; set; }
        public string Mail2 { get; set; }
        public string AboutUs { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
        public string SupportGsm { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class Attore
    {
        public Attore()
        {
            Interpretaziones = new HashSet<Interpretazione>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public virtual ICollection<Interpretazione> Interpretaziones { get; set; }
    }
}

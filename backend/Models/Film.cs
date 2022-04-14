using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class Film
    {
        public Film()
        {
            Direziones = new HashSet<Direzione>();
            Interpretaziones = new HashSet<Interpretazione>();
        }

        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public int? Durata { get; set; }

        public virtual ICollection<Direzione> Direziones { get; set; }
        public virtual ICollection<Interpretazione> Interpretaziones { get; set; }
    }
}

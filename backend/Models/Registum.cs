using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class Registum
    {
        public Registum()
        {
            Direziones = new HashSet<Direzione>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public virtual ICollection<Direzione> Direziones { get; set; }
    }
}

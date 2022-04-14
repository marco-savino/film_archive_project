using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class Interpretazione
    {
        public int Id { get; set; }
        public int? IdFilm { get; set; }
        public int? IdAttore { get; set; }
        public bool? Protagonista { get; set; }

        public virtual Attore IdAttoreNavigation { get; set; }
        public virtual Film IdFilmNavigation { get; set; }
    }
}

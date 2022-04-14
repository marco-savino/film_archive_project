using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class Direzione
    {
        public int Id { get; set; }
        public int? IdRegista { get; set; }
        public int? IdFilm { get; set; }

        public virtual Film IdFilmNavigation { get; set; }
        public virtual Registum IdRegistaNavigation { get; set; }
    }
}

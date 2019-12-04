using System;
using System.Collections.Generic;

namespace Poer.Models
{
    public partial class Klient
    {
        public int IdKlient { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NumerTelefonu { get; set; }
        public string Mail { get; set; }
    }
}

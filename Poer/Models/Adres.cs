using System;
using System.Collections.Generic;

namespace Poer.Models
{
    public partial class Adres
    {
        public int IdAdres { get; set; }
        public string Miasto { get; set; }
        public int NrDomu { get; set; }
        public string Ulica { get; set; }
        public int NrMieszkania { get; set; }
    }
}

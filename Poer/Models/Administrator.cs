﻿using System;
using System.Collections.Generic;

namespace Poer.Models
{
    public partial class Administrator
    {
        public int IdAdmin { get; set; }
        public string Login { get; set; }
        public string Passoword { get; set; }
        public string Mail { get; set; }
    }
}

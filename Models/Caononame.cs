using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class Caononame
{
    public int? CaononameNonameid { get; set; }

    public int? CaononameOrderid { get; set; }

    public virtual NonameClient? CaononameNoname { get; set; }

    public virtual Order? CaononameOrder { get; set; }
}

using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class TypeOfAcrylic
{
    public int TypeofacrylicId { get; set; }

    public string TypeofacrylicThickness { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

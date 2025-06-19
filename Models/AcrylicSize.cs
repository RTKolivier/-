using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class AcrylicSize
{
    public int AcrylicsizeId { get; set; }

    public string? AcrylicsizeSize { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class Hardware
{
    public int HardwareId { get; set; }

    public int? HardwareTypeid { get; set; }

    public int? HardwareColorid { get; set; }

    public int HardwareQuantity { get; set; }

    public int? HardwarePriceid { get; set; }

    public virtual HardwareColor? HardwareColor { get; set; }

    public virtual HardwarePrice? HardwarePrice { get; set; }

    public virtual TypeOfHardware? HardwareType { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

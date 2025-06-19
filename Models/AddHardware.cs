using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class AddHardware
{
    public int AddhardwareId { get; set; }

    public int? AddhardwareSizeid { get; set; }

    public int? AddhardwareColorid { get; set; }

    public int? AddhardwarePriceid { get; set; }

    public virtual HardwareColor? AddhardwareColor { get; set; }

    public virtual HardwarePrice? AddhardwarePrice { get; set; }

    public virtual AddHardwareSize? AddhardwareSize { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

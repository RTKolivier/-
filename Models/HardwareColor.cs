using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class HardwareColor
{
    public int HardwarecolorId { get; set; }

    public string HardwarecolorColor { get; set; } = null!;

    public virtual ICollection<AddHardware> AddHardwares { get; set; } = new List<AddHardware>();

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();
}

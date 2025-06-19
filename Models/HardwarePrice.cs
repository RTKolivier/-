using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class HardwarePrice
{
    public int HardwarepriceId { get; set; }

    public int HardwarepricePrice { get; set; }

    public virtual ICollection<AddHardware> AddHardwares { get; set; } = new List<AddHardware>();

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();
}

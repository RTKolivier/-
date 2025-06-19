using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class TypeOfHardware
{
    public int TypeofhardwareId { get; set; }

    public string TypeofhardwareType { get; set; } = null!;

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();
}

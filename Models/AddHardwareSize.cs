using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class AddHardwareSize
{
    public int AddhardwaresizeId { get; set; }

    public string AddhardwaresizeSize { get; set; } = null!;

    public virtual ICollection<AddHardware> AddHardwares { get; set; } = new List<AddHardware>();
}

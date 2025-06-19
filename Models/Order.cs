using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class Order
{
    public int OrdersId { get; set; }

    public string OrdersFilesname { get; set; } = null!;

    public DateOnly OrdersDate { get; set; }

    public int? OrdersTypeacrylicid { get; set; }

    public int OrdersQuantity { get; set; }

    public int? OrdersHardwareid { get; set; }

    public int OrdersQuantityhardware { get; set; }

    public int? OrdersAddhardware { get; set; }

    public int OrdersQuantityaddhardware { get; set; }

    public int OrdersPrice { get; set; }

    public int? AcrylicSize { get; set; }

    public virtual AcrylicSize? AcrylicSizeNavigation { get; set; }

    public virtual AddHardware? OrdersAddhardwareNavigation { get; set; }

    public virtual Hardware? OrdersHardware { get; set; }

    public virtual TypeOfAcrylic? OrdersTypeacrylic { get; set; }
}

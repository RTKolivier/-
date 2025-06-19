using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class Cao
{
    public int? CaoClientsid { get; set; }

    public int? CaoOrdersid { get; set; }

    public virtual Client? CaoClients { get; set; }

    public virtual Order? CaoOrders { get; set; }
}

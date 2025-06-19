using System;
using System.Collections.Generic;

namespace курчас.Models;

public partial class Client
{
    public int ClientsId { get; set; }

    public string ClientsNick { get; set; } = null!;

    public string ClientsUsername { get; set; } = null!;

    public string ClientsFio { get; set; } = null!;

    public string ClientsPhone { get; set; } = null!;

    public string ClientsCity { get; set; } = null!;

    public string ClientsOpp { get; set; } = null!;

    public string ClientsAddress { get; set; } = null!;

    public string? ClientsPassword { get; set; }
}

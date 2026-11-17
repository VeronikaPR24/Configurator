using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Storage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Interface { get; set; } = null!;

    public int Capacity { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

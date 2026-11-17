using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Motherboard
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Socket { get; set; } = null!;

    public string MemoryType { get; set; } = null!;

    public string FormFactor { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Ram
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string MemoryType { get; set; } = null!;

    public int Capacity { get; set; }

    public int Frequency { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

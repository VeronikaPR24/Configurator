using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Processor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Socket { get; set; } = null!;

    public int CoresCount { get; set; }

    public int EnergyConsumption { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

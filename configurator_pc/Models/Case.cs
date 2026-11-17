using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Case
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string FormFactor { get; set; } = null!;

    public int MaxGpu { get; set; }

    public int MaxCooler { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

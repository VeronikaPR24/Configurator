using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Gpu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Vram { get; set; }

    public int Length { get; set; }

    public int EnergyConsumption { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Power
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Wattage { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

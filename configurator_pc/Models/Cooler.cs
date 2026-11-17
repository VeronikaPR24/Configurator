using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Cooler
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Socket { get; set; } = null!;

    public int Height { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }
}

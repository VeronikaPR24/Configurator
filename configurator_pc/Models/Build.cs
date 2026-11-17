using System;
using System.Collections.Generic;

namespace configurator_pc.Models;

public partial class Build
{
    public int IdUser { get; set; }

    public int IdBuilds { get; set; }

    public int IdProcessor { get; set; }

    public int IdMotherboard { get; set; }

    public int IdRam { get; set; }

    public int IdGpu { get; set; }

    public int IdStorage { get; set; }

    public int IdPower { get; set; }

    public int IdCooler { get; set; }

    public int IdCase { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual Case IdCaseNavigation { get; set; } = null!;

    public virtual Cooler IdCoolerNavigation { get; set; } = null!;

    public virtual Gpu IdGpuNavigation { get; set; } = null!;

    public virtual Motherboard IdMotherboardNavigation { get; set; } = null!;

    public virtual Power IdPowerNavigation { get; set; } = null!;

    public virtual Processor IdProcessorNavigation { get; set; } = null!;

    public virtual Ram IdRamNavigation { get; set; } = null!;

    public virtual Storage IdStorageNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}

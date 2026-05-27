using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPNYOLCMASODJARA.Models;

public partial class Motorcycle
{
    [Key]
    [Column("MotorcycleID")]
    public int MotorcycleId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ModelName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BrandName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BrandOrigin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OwnerFirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OwnerLastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OwnerContact { get; set; }

    public DateOnly? ManufactureDate { get; set; }

    public int? EngineCapacity { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Color { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RaceName { get; set; }

    public DateOnly? RaceDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RaceLocation { get; set; }

    public int? RaceDistance { get; set; }

    public int? FinishPosition { get; set; }
}

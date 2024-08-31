﻿using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entites;

public class Country
{
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Name { get; set; } = null!;

    // Relacion de uno a muchos
    public ICollection<Team>? Teams { get; set; }

    // Propiedad de lectura
    public int TeamsCount => Teams == null ? 0 : Teams.Count;
}
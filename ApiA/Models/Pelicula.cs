using System;
using System.Collections.Generic;

namespace ApiA.Models;

public partial class Pelicula
{
    public int IdPelicula { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Genero { get; set; }

    public string? Director { get; set; }

    public int? AnioEstreno { get; set; }

    public int? Duracion { get; set; }

    public string? Sinopsis { get; set; }

    public DateTime? FechaCreacion { get; set; }
}

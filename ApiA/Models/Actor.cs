using System;
using System.Collections.Generic;

namespace ApiA.Models;

public partial class Actor
{
    public int IdActor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? Nacionalidad { get; set; }

    public string? GeneroBiografia { get; set; }

    public string? Premios { get; set; }

    public int? NumeroPeliculas { get; set; }

    public string? FechaCreacion { get; set; }
}

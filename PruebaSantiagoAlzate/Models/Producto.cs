﻿using System;
using System.Collections.Generic;

namespace PruebaSantiagoAlzate.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Peso { get; set; }

    public int? Calorias { get; set; }
}

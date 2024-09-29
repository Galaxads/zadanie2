using System;
using System.Collections.Generic;

namespace AvaloniaApplication6.Models;

public partial class Manuf
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

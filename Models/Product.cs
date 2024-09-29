using System;
using System.Collections.Generic;

namespace AvaloniaApplication6.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public string? Photo { get; set; }

    public int? Isactive { get; set; }

    public int? Manufactured { get; set; }

    public string? Description { get; set; }

    public virtual Manuf? ManufacturedNavigation { get; set; }
}

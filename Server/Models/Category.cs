using System;
using System.Collections.Generic;

namespace Server.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int SortOrder { get; set; }
}

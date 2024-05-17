using System;
using System.Collections.Generic;

namespace Threads.DataTier.Models;

public partial class Medium
{
    public int MediaId { get; set; }

    public int? PostId { get; set; }

    public string MediaType { get; set; } = null!;

    public string MediaUrl { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Post? Post { get; set; }
}

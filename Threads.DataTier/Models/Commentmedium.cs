using System;
using System.Collections.Generic;

namespace Threads.DataTier.Models;

public partial class Commentmedium
{
    public int MediaId { get; set; }

    public int? CommentId { get; set; }

    public string MediaType { get; set; } = null!;

    public string MediaUrl { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Comment? Comment { get; set; }
}

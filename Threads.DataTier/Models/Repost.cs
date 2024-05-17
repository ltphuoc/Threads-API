using System;
using System.Collections.Generic;

namespace Threads.DataTier.Models;

public partial class Repost
{
    public int RepostId { get; set; }

    public int? UserId { get; set; }

    public int? PostId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}

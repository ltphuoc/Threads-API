using System;
using System.Collections.Generic;

namespace Threads.DataTier.Models;

public partial class Savedpost
{
    public int SavedPostId { get; set; }

    public int? UserId { get; set; }

    public int? PostId { get; set; }

    public DateTime? SavedAt { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
